/*
 * Load the content of a PFX/P12 file into a smart card using the Microsoft Base CSP.
 * 
 * Copyright (c) 2014-2015 Mounir IDRASSI <mounir.idrassi@idrix.fr>. All rights reserved.
 * 
 * This sample uses the first available smart card
 *
 * As documented in the smart card minidriver specification, two registry keys 
 * must be modified to permit the import operation : 
 * 
 * HKLM\SOFTWARE\Microsoft\Cryptography\Defaults\Provider\
 *   Microsoft Base Smart Card Crypto Provider\AllowPrivateExchangeKeyImport=DWORD:0x1
 *
 * HKLM\SOFTWARE\Microsoft\Cryptography\Defaults\Provider\
 *   Microsoft Base Smart Card Crypto Provider\AllowPrivateSignatureKeyImport=DWORD:0x1
 *   
 * If your Windows is 64-bit and your application is 32-bit, then the following keys
 * must also be modified (similar to above but under Wow6432Node):
 * 
 * HKLM\SOFTWARE\Wow6432Node\Microsoft\Cryptography\Defaults\Provider\
 *   Microsoft Base Smart Card Crypto Provider\AllowPrivateExchangeKeyImport=DWORD:0x1
 *
 * HKLM\SOFTWARE\Wow6432Node\Microsoft\Cryptography\Defaults\Provider\
 *   Microsoft Base Smart Card Crypto Provider\AllowPrivateSignatureKeyImport=DWORD:0x1
 *
 * **************************************************************************************
 * Copyright (c) 2014-2015 Mounir IDRASSI <mounir.idrassi@idrix.fr>. All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice, this
 *   list of conditions and the following disclaimer.
 *
 * - Redistributions in binary form must reproduce the above copyright notice,
 *   this list of conditions and the following disclaimer in the documentation
 *   and/or other materials provided with the distribution.
 *
 * - Neither the name of PfxImporter nor the names of its
 *   contributors may be used to endorse or promote products derived from
 *   this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

public class PfxImporter
	{
		public enum ProviderType : uint
		{
			PROV_RSA_FULL = 1,
			PROV_RSA_SIG = 2,
			PROV_DSS = 3,
			PROV_FORTEZZA = 4,
			PROV_MS_EXCHANGE = 5,
			PROV_SSL = 6,
			PROV_RSA_SCHANNEL = 12,
			PROV_DSS_DH = 13,
			PROV_EC_ECDSA_SIG = 14,
			PROV_EC_ECNRA_SIG = 15,
			PROV_EC_ECDSA_FULL = 16,
			PROV_EC_ECNRA_FULL = 17,
			PROV_DH_SCHANNEL = 18,
			PROV_SPYRUS_LYNKS = 20,
			PROV_RNG = 21,
			PROV_INTEL_SEC = 22,
			PROV_REPLACE_OWF = 23,
			PROV_RSA_AES = 24,
		}

		[Flags]
		public enum ContextFlags : uint
		{
			CRYPT_VERIFYCONTEXT = 0xF0000000,
			CRYPT_NEWKEYSET = 0x00000008,
			CRYPT_DELETEKEYSET = 0x00000010,
			CRYPT_MACHINE_KEYSET = 0x00000020,
			CRYPT_SILENT = 0x00000040,
			CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x00000080,
		}

		public enum ProviderParamType : uint
		{
			PP_CLIENT_HWND = 1,
			PP_ENUMALGS = 1,
			PP_ENUMCONTAINERS = 2,
			PP_IMPTYPE = 3,
			PP_NAME = 4,
			PP_VERSION = 5,
			PP_CONTAINER = 6,
			PP_CHANGE_PASSWORD = 7,
			PP_KEYSET_SEC_DESCR = 8,
			PP_CERTCHAIN = 9,
			PP_KEY_TYPE_SUBTYPE = 10,
			PP_CONTEXT_INFO = 11,
			PP_KEYEXCHANGE_KEYSIZE = 12,
			PP_SIGNATURE_KEYSIZE = 13,
			PP_KEYEXCHANGE_ALG = 14,
			PP_SIGNATURE_ALG = 15,
			PP_PROVTYPE = 16,
			PP_KEYSTORAGE = 17,
			PP_APPLI_CERT = 18,
			PP_SYM_KEYSIZE = 19,
			PP_SESSION_KEYSIZE = 20,
			PP_UI_PROMPT = 21,
			PP_ENUMALGS_EX = 22,
			PP_DELETEKEY = 24,
			PP_ENUMMANDROOTS = 25,
			PP_ENUMELECTROOTS = 26,
			PP_KEYSET_TYPE = 27,
			PP_ADMIN_PIN = 31,
			PP_KEYEXCHANGE_PIN = 32,
			PP_SIGNATURE_PIN = 33,
			PP_SIG_KEYSIZE_INC = 34,
			PP_KEYX_KEYSIZE_INC = 35,
			PP_UNIQUE_CONTAINER = 36,
			PP_SGC_INFO = 37,
			PP_USE_HARDWARE_RNG = 38,
			PP_KEYSPEC = 39,
			PP_ENUMEX_SIGNING_PROT = 40,
			PP_CRYPT_COUNT_KEY_USE = 41,
		}

		public enum KeyParameter : uint
		{
			KP_IV = 1,
			KP_SALT = 2,
			KP_PADDING = 3,
			KP_MODE = 4,
			KP_MODE_BITS = 5,
			KP_PERMISSIONS = 6,
			KP_ALGID = 7,
			KP_BLOCKLEN = 8,
			KP_KEYLEN = 9,
			KP_SALT_EX = 10,
			KP_P = 11,
			KP_G = 12,
			KP_Q = 13,
			KP_X = 14,
			KP_Y = 15,
			KP_RA = 16,
			KP_RB = 17,
			KP_INFO = 18,
			KP_EFFECTIVE_KEYLEN = 19,
			KP_SCHANNEL_ALG = 20,
			KP_CLIENT_RANDOM = 21,
			KP_SERVER_RANDOM = 22,
			KP_RP = 23,
			KP_PRECOMP_MD5 = 24,
			KP_PRECOMP_SHA = 25,
			KP_CERTIFICATE = 26,
			KP_CLEAR_KEY = 27,
			KP_PUB_EX_LEN = 28,
			KP_PUB_EX_VAL = 29,
			KP_KEYVAL = 30,
			KP_ADMIN_PIN = 31,
			KP_KEYEXCHANGE_PIN = 32,
			KP_SIGNATURE_PIN = 33,
			KP_PREHASH = 34,
			KP_ROUNDS = 35,
			KP_OAEP_PARAMS = 36,
			KP_CMS_KEY_INFO = 37,
			KP_CMS_DH_KEY_INFO = 38,
			KP_PUB_PARAMS = 39,
			KP_VERIFY_PARAMS = 40,
			KP_HIGHEST_VERSION = 41,
			KP_GET_USE_COUNT = 42,
		}

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern Boolean CryptAcquireContext(
			 ref IntPtr hProv,
			 string pszContainer,
			 string pszProvider,
			 ProviderType dwProvType,
			 ContextFlags dwFlags);

		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern Boolean CryptGetProvParam(
			 IntPtr hProv,
			 ProviderParamType dwParam,
			 StringBuilder pbData,
			 ref UInt32 pdwDataLen,
			 UInt32 dwFlags);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern Boolean CryptImportKey(
			 IntPtr hProv,
			 byte[] pbKeyData,
			 UInt32 dwDataLen,
			 IntPtr hPubKey,
			 UInt32 dwFlags,
			 ref IntPtr hKey);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern Boolean CryptSetKeyParam(
			 IntPtr hKey,
			 KeyParameter dwParam,
			 byte[] pbData,
			 UInt32 dwFlags);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern Boolean CryptDestroyKey(
			 IntPtr phKey);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern Boolean CryptReleaseContext(
			 IntPtr hProv,
			 UInt32 dwFlags);

        public static bool ImportPfxFileToCard(byte[] fileContent, string password, X509KeyStorageFlags x509KeyStorageFlags = X509KeyStorageFlags.Exportable)
        {
            X509Certificate2 x509 = new X509Certificate2(fileContent, password, x509KeyStorageFlags);
            if (x509.HasPrivateKey)
            {
                if (x509.PublicKey.Oid.FriendlyName.Contains("RSA"))
                {
                    RSACryptoServiceProvider key = (RSACryptoServiceProvider)x509.PrivateKey;
                    byte[] pBlob = key.ExportCspBlob(true);
                    byte[] pbCert = x509.RawData;

                    Console.WriteLine("Found {0} bits RSA private key. Loading into the smart card.\n", key.KeySize);
                    Console.WriteLine("For the MS Base Smart Card CSP, two registry values must first be set to 1 : ");
                    Console.WriteLine("\tAllowPrivateExchangeKeyImport.\n\tAllowPrivateSignatureKeyImport.\n");

                    IntPtr hProv = IntPtr.Zero;
                    string szMSBaseCsp = "Microsoft Base Smart Card Crypto Provider";

                    bool bStatus = CryptAcquireContext(ref hProv, "", szMSBaseCsp, ProviderType.PROV_RSA_FULL, ContextFlags.CRYPT_NEWKEYSET);
                    if (bStatus)
                    {
                        // Get the container name
                        string szContainerName = "";
                        StringBuilder szVal = new StringBuilder(1024);
                        uint dwDataLen = 1024;

                        bStatus = CryptGetProvParam(hProv, ProviderParamType.PP_CONTAINER, szVal, ref dwDataLen, 0);
                        if (bStatus)
                            szContainerName = szVal.ToString();

                        IntPtr hKey = IntPtr.Zero;
                        bStatus = CryptImportKey(hProv, pBlob, (UInt32)pBlob.Length, IntPtr.Zero, 0, ref hKey);
                        if (bStatus)
                        {
                            bStatus = CryptSetKeyParam(hKey, KeyParameter.KP_CERTIFICATE, pbCert, 0);
                            if (bStatus)
                            {
                                Console.WriteLine("Key and certificate loaded successfully into the card");
                                if (szContainerName.Length > 0)
                                {
                                    Console.WriteLine("\tUsed container = \"{0}\"", szContainerName);
                                }
                            }
                            else
                            {
                                //Win32Exception ex = new Win32Exception();
                                //Console.WriteLine("Private key imported into the card but certificate loading failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\nDescription : " + ex.Message);
                            }
                            CryptDestroyKey(hKey);
                        }
                        else
                        {
                            //Win32Exception ex = new Win32Exception();
                            //Console.WriteLine("CryptImportKey failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\n\tDescription : " + ex.Message);
                        }

                        CryptReleaseContext(hProv, 0);

                        if (!bStatus && szContainerName.Length > 0)
                        {
                            // delete the container because there was an error
                            CryptAcquireContext(ref hProv, szContainerName, szMSBaseCsp, ProviderType.PROV_RSA_FULL, ContextFlags.CRYPT_DELETEKEYSET);
                        }

                        return true;
                    }
                    else
                    {
                        //Win32Exception ex = new Win32Exception();
                        //Console.WriteLine("CryptAcquireContext failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\n\tDescription : " + ex.Message);

                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("PFX file contains an unsupported key type ({0})", x509.PublicKey.Oid.FriendlyName);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No private key found in the PFX file");
                return false;
            }
        }

    public static bool ImportPfxFileToCard(X509Certificate2 x509)
    {
        if (x509.HasPrivateKey)
        {
            if (x509.PublicKey.Oid.FriendlyName.Contains("RSA"))
            {
                RSACryptoServiceProvider key = (RSACryptoServiceProvider)x509.PrivateKey;
                //byte[] pBlob = key.ExportCspBlob(true);
                byte[] pbCert = x509.RawData;

                //Console.WriteLine("Found {0} bits RSA private key. Loading into the smart card.\n", key.KeySize);
                Console.WriteLine("For the MS Base Smart Card CSP, two registry values must first be set to 1 : ");
                Console.WriteLine("\tAllowPrivateExchangeKeyImport.\n\tAllowPrivateSignatureKeyImport.\n");

                IntPtr hProv = IntPtr.Zero;
                string szMSBaseCsp = "Microsoft Base Smart Card Crypto Provider";
                //string szMSBaseCsp = "Microsoft Strong Cryptographic Provider";

                bool bStatus = CryptAcquireContext(ref hProv, "", szMSBaseCsp, ProviderType.PROV_RSA_FULL, ContextFlags.CRYPT_NEWKEYSET);
                if (bStatus)
                {
                    // Get the container name
                    string szContainerName = "";
                    StringBuilder szVal = new StringBuilder(1024);
                    uint dwDataLen = 1024;

                    bStatus = CryptGetProvParam(hProv, ProviderParamType.PP_CONTAINER, szVal, ref dwDataLen, 0);
                    if (bStatus)
                        szContainerName = szVal.ToString();

                    IntPtr hKey = IntPtr.Zero;
                    //bStatus = CryptImportKey(hProv, pBlob, (UInt32)pBlob.Length, IntPtr.Zero, 0, ref hKey);
                    if (bStatus)
                    {
                        bStatus = CryptSetKeyParam(hKey, KeyParameter.KP_CERTIFICATE, pbCert, 0);
                        if (bStatus)
                        {
                            Console.WriteLine("Key and certificate loaded successfully into the card");
                            if (szContainerName.Length > 0)
                            {
                                Console.WriteLine("\tUsed container = \"{0}\"", szContainerName);
                            }
                        }
                        else
                        {
                            //Win32Exception ex = new Win32Exception();
                            //Console.WriteLine("Private key imported into the card but certificate loading failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\nDescription : " + ex.Message);
                        }
                        CryptDestroyKey(hKey);
                    }
                    else
                    {
                        //Win32Exception ex = new Win32Exception();
                        //Console.WriteLine("CryptImportKey failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\n\tDescription : " + ex.Message);
                    }

                    CryptReleaseContext(hProv, 0);

                    if (!bStatus && szContainerName.Length > 0)
                    {
                        // delete the container because there was an error
                        CryptAcquireContext(ref hProv, szContainerName, szMSBaseCsp, ProviderType.PROV_RSA_FULL, ContextFlags.CRYPT_DELETEKEYSET);
                    }

                    return true;
                }
                else
                {
                    //Win32Exception ex = new Win32Exception();
                    //Console.WriteLine("CryptAcquireContext failed with error 0x" + ex.NativeErrorCode.ToString("X8") + "\n\tDescription : " + ex.Message);

                    return false;
                }
            }
            else
            {
                Console.WriteLine("PFX file contains an unsupported key type ({0})", x509.PublicKey.Oid.FriendlyName);
                return false;
            }
        }
        else
        {
            Console.WriteLine("No private key found in the PFX file");
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            store.Add(x509);
            store.Close();
            return false;
        }
    }

}
