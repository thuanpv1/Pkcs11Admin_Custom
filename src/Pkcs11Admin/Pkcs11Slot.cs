

using Net.Pkcs11Admin.Configuration;
using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using Net.Pkcs11Interop.HighLevelAPI.Factories;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Net.Pkcs11Admin
{
    public class Pkcs11Slot : IDisposable
    {
        public string authenticatedAlready = "authenticatedAlready";
        public string connectToCardUnsuccessfully = "connectToCardUnsuccessfully";
        public string authenticatedSuccessfully = "authenticatedSuccessfully";
        public string theCardIsBlocked = "theCardIsBlocked";
        public string thePINIsInCorrect = "thePINIsInCorrect";
        public string authenticatedUnSuccessfully = "authenticatedUnSuccessfully";

        private bool _disposed = false;

        private ISlot _slot = null;

        private ISession _authenticatedSession = null;

        #region Properties

        public Pkcs11SlotInfo SlotInfo
        {
            get;
            private set;
        }

        public Exception SlotInfoException
        {
            get;
            private set;
        }

        public Pkcs11TokenInfo TokenInfo
        {
            get;
            private set;
        }

        public Exception TokenInfoException
        {
            get;
            private set;
        }

        public Pkcs11SessionInfo SessionInfo
        {
            get;
            private set;
        }

        public Exception SessionInfoException
        {
            get;
            private set;
        }

        public List<Pkcs11MechanismInfo> Mechanisms
        {
            get;
            private set;
        }

        public Exception MechanismsException
        {
            get;
            private set;
        }

        public List<Pkcs11HwFeatureInfo> HwFeatures
        {
            get;
            private set;
        }

        public Exception HwFeaturesException
        {
            get;
            private set;
        }

        public List<Pkcs11DataObjectInfo> DataObjects
        {
            get;
            private set;
        }

        public Exception DataObjectsException
        {
            get;
            private set;
        }

        public List<Pkcs11CertificateInfo> Certificates
        {
            get;
            private set;
        }

        public Exception CertificatesException
        {
            get;
            private set;
        }

        public List<Pkcs11KeyInfo> Keys
        {
            get;
            private set;
        }

        public Exception KeysException
        {
            get;
            private set;
        }

        public List<Pkcs11DomainParamsInfo> DomainParams
        {
            get;
            private set;
        }

        public Exception DomainParamsException
        {
            get;
            private set;
        }

        #endregion

        #region Constructor

        public Pkcs11Slot(ISlot slot)
        {
            _slot = slot;

            Reload(true);
        }

        public Pkcs11Slot()
        {
            _slot = null;
        }

        public ISlot getSlot()
        {
            return _slot;
        }

        #endregion

        #region Slot information gathering

        private void MarkSlotAsUsable()
        {
            SlotInfo = null;
            SlotInfoException = null;

            TokenInfo = null;
            TokenInfoException = null;

            SessionInfo = null;
            SessionInfoException = null;

            Mechanisms = null;
            MechanismsException = null;

            HwFeatures = null;
            HwFeaturesException = null;

            DataObjects = null;
            DataObjectsException = null;

            Certificates = null;
            CertificatesException = null;

            Keys = null;
            KeysException = null;

            DomainParams = null;
            DomainParamsException = null;
        }

        private void MarkSlotAsUnusable(Exception ex, bool isSlotInfoException = false, bool isTokenInfoException = false, bool isSessionInfoException = false)
        {
            if (isSlotInfoException)
            {
                SlotInfo = null;
                SlotInfoException = ex;
            }

            if (isSlotInfoException || isTokenInfoException)
            {
                TokenInfo = null;
                TokenInfoException = ex;
            }

            if (isSlotInfoException || isTokenInfoException || isSessionInfoException)
            {
                SessionInfo = null;
                SessionInfoException = ex;
            }

            Mechanisms = null;
            MechanismsException = ex;

            HwFeatures = null;
            HwFeaturesException = ex;

            DataObjects = null;
            DataObjectsException = ex;

            Certificates = null;
            CertificatesException = ex;

            Keys = null;
            KeysException = ex;

            DomainParams = null;
            DomainParamsException = ex;
        }

        public void Reload()
        {
            Reload(false);
        }

        private void Reload(bool onlySlotInfo)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            MarkSlotAsUsable();

            try
            {
                SlotInfo = ReadSlotInfo();
                SlotInfoException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                // In order to keep the code sane consider slot unusable if C_GetSlotInfo fails
                MarkSlotAsUnusable(ex, isSlotInfoException: true);
                return;
            }

            if (onlySlotInfo)
                return;

            try
            {
                if (!SlotInfo.TokenPresent)
                    throw new TokenNotPresentException();

                TokenInfo = ReadTokenInfo();
                TokenInfoException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                // In order to keep the code sane consider slot unusable if C_GetTokenInfo fails
                MarkSlotAsUnusable(ex, isTokenInfoException: true);
                return;
            }

            try
            {
                SessionInfo = ReadSessionInfo();
                SessionInfoException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                // In order to keep the code sane consider slot unusable if C_GetSessionInfo fails
                MarkSlotAsUnusable(ex, isSessionInfoException: true);
                return;
            }

            try
            {
                Mechanisms = ReadMechanisms();
                MechanismsException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                Mechanisms = null;
                MechanismsException = ex;
            }

            try
            {
                HwFeatures = ReadHwFeatures();
                HwFeaturesException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                HwFeatures = null;
                HwFeaturesException = ex;
            }

            try
            {
                DataObjects = ReadDataObjects();
                DataObjectsException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                DataObjects = null;
                DataObjectsException = ex;
            }

            try
            {
                Certificates = ReadCertificates();
                CertificatesException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                Certificates = null;
                CertificatesException = ex;
            }

            try
            {
                Keys = ReadKeys();
                KeysException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                Keys = null;
                KeysException = ex;
            }

            try
            {
                DomainParams = ReadDomainParams();
                DomainParamsException = null;
            }
            catch (Exception ex)
            {
                // TODO - Log exception

                DomainParams = null;
                DomainParamsException = ex;
            }
        }

        private Pkcs11SlotInfo ReadSlotInfo()
        {
            return new Pkcs11SlotInfo(_slot.GetSlotInfo());
        }

        private Pkcs11TokenInfo ReadTokenInfo()
        {
            return new Pkcs11TokenInfo(_slot.GetTokenInfo());
        }

        private Pkcs11SessionInfo ReadSessionInfo()
        {
            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                return new Pkcs11SessionInfo(session.GetSessionInfo(), TokenInfo.ProtectedAuthenticationPath);
        }

        private List<Pkcs11MechanismInfo> ReadMechanisms()
        {
            List<Pkcs11MechanismInfo> mechanisms = new List<Pkcs11MechanismInfo>();
            foreach (CKM mechanism in _slot.GetMechanismList())
            {
                IMechanismInfo mechanismInfo = _slot.GetMechanismInfo(mechanism);
                mechanisms.Add(new Pkcs11MechanismInfo(mechanism, mechanismInfo));
            }

            return mechanisms;
        }

        private List<Pkcs11HwFeatureInfo> ReadHwFeatures()
        {
            List<Pkcs11HwFeatureInfo> infos = new List<Pkcs11HwFeatureInfo>();

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> searchTemplate = new List<IObjectAttribute>();
                searchTemplate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_HW_FEATURE));

                List<IObjectHandle> foundObjects = session.FindAllObjects(searchTemplate);
                foreach (IObjectHandle foundObject in foundObjects)
                {
                    // Read attributes required for sane object presentation
                    List<ulong> attributes = new List<ulong>();
                    attributes.Add((ulong)CKA.CKA_HW_FEATURE_TYPE);

                    List<IObjectAttribute> requiredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read attributes configured for specific object class and type
                    attributes = new List<ulong>();
                    foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.HwFeatureAttributes.CommonAttributes)
                        attributes.Add(classAttribute.Value);
                    ulong featureType = requiredAttributes[0].GetValueAsUlong();
                    if (Pkcs11Admin.Instance.Config.HwFeatureAttributes.TypeSpecificAttributes.ContainsKey(featureType))
                        foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.HwFeatureAttributes.TypeSpecificAttributes[featureType])
                            attributes.Add(classAttribute.Value);

                    List<IObjectAttribute> configuredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read object storage size
                    ulong? storageSize = ReadObjectSize(session, foundObject);

                    // Construct info object
                    Pkcs11HwFeatureInfo info = new Pkcs11HwFeatureInfo(foundObject, configuredAttributes, storageSize)
                    {
                        CkaHwFeatureType = requiredAttributes[0].GetValueAsUlong()
                    };

                    infos.Add(info);
                }
            }

            return infos;
        }

        private List<Pkcs11DataObjectInfo> ReadDataObjects()
        {
            List<Pkcs11DataObjectInfo> infos = new List<Pkcs11DataObjectInfo>();

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> searchTemplate = new List<IObjectAttribute>();
                searchTemplate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_DATA));

                List<IObjectHandle> foundObjects = session.FindAllObjects(searchTemplate);
                foreach (IObjectHandle foundObject in foundObjects)
                {
                    // Read attributes required for sane object presentation
                    List<ulong> attributes = new List<ulong>();
                    attributes.Add((ulong)CKA.CKA_PRIVATE);
                    attributes.Add((ulong)CKA.CKA_LABEL);
                    attributes.Add((ulong)CKA.CKA_APPLICATION);

                    List<IObjectAttribute> requiredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read attributes configured for specific object class
                    attributes = new List<ulong>();
                    foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.DataObjectAttributes.CommonAttributes)
                        attributes.Add(classAttribute.Value);

                    List<IObjectAttribute> configuredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read object storage size
                    ulong? storageSize = ReadObjectSize(session, foundObject);

                    // Construct info object
                    Pkcs11DataObjectInfo info = new Pkcs11DataObjectInfo(foundObject, configuredAttributes, storageSize)
                    {
                        CkaPrivate = requiredAttributes[0].GetValueAsBool(),
                        CkaLabel = requiredAttributes[1].GetValueAsString(),
                        CkaApplication = requiredAttributes[2].GetValueAsString(),
                        StorageSize = storageSize
                    };

                    infos.Add(info);
                }
            }

            return infos;
        }

        private List<Pkcs11CertificateInfo> ReadCertificates()
        {
            List<Pkcs11CertificateInfo> infos = new List<Pkcs11CertificateInfo>();

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> searchTemplate = new List<IObjectAttribute>();
                searchTemplate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_CERTIFICATE));

                List<IObjectHandle> foundObjects = session.FindAllObjects(searchTemplate);
                foreach (IObjectHandle foundObject in foundObjects)
                {
                    // Read attributes required for sane object presentation
                    List<ulong> attributes = new List<ulong>();
                    attributes.Add((ulong)CKA.CKA_PRIVATE);
                    attributes.Add((ulong)CKA.CKA_CERTIFICATE_TYPE);
                    attributes.Add((ulong)CKA.CKA_LABEL);
                    attributes.Add((ulong)CKA.CKA_ID);
                    attributes.Add((ulong)CKA.CKA_VALUE);

                    List<IObjectAttribute> requiredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read attributes configured for specific object class and type
                    attributes = new List<ulong>();
                    foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.CertificateAttributes.CommonAttributes)
                        attributes.Add(classAttribute.Value);
                    ulong certType = requiredAttributes[1].GetValueAsUlong();
                    if (Pkcs11Admin.Instance.Config.CertificateAttributes.TypeSpecificAttributes.ContainsKey(certType))
                        foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.CertificateAttributes.TypeSpecificAttributes[certType])
                            attributes.Add(classAttribute.Value);

                    List<IObjectAttribute> configuredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read object storage size
                    ulong? storageSize = ReadObjectSize(session, foundObject);

                    // Construct info object
                    Pkcs11CertificateInfo info = new Pkcs11CertificateInfo(foundObject, configuredAttributes, storageSize)
                    {
                        CkaPrivate = requiredAttributes[0].GetValueAsBool(),
                        CkaCertificateType = requiredAttributes[1].GetValueAsUlong(),
                        CkaLabel = requiredAttributes[2].GetValueAsString(),
                        CkaId = requiredAttributes[3].GetValueAsByteArray(),
                        CkaValue = requiredAttributes[4].GetValueAsByteArray()
                    };

                    infos.Add(info);
                }
            }

            return infos;
        }

        private List<Pkcs11KeyInfo> ReadKeys(CKO objectClass, ClassAttributesDefinition keyAttributes)
        {
            List<Pkcs11KeyInfo> infos = new List<Pkcs11KeyInfo>();

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> searchTemplate = new List<IObjectAttribute>();
                searchTemplate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, objectClass));

                List<IObjectHandle> foundObjects = session.FindAllObjects(searchTemplate);
                foreach (IObjectHandle foundObject in foundObjects)
                {
                    // Read attributes required for sane object presentation
                    List<ulong> attributes = new List<ulong>();
                    attributes.Add((ulong)CKA.CKA_PRIVATE);
                    attributes.Add((ulong)CKA.CKA_KEY_TYPE);
                    attributes.Add((ulong)CKA.CKA_LABEL);
                    attributes.Add((ulong)CKA.CKA_ID);

                    List<IObjectAttribute> requiredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read attributes configured for specific object class and type
                    attributes = new List<ulong>();
                    foreach (ClassAttribute classAttribute in keyAttributes.CommonAttributes)
                        attributes.Add(classAttribute.Value);
                    ulong keyType = requiredAttributes[1].GetValueAsUlong();
                    if (keyAttributes.TypeSpecificAttributes.ContainsKey(keyType))
                        foreach (ClassAttribute classAttribute in keyAttributes.TypeSpecificAttributes[keyType])
                            attributes.Add(classAttribute.Value);

                    List<IObjectAttribute> configuredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read object storage size
                    ulong? storageSize = ReadObjectSize(session, foundObject);

                    // Construct info object
                    Pkcs11KeyInfo info = new Pkcs11KeyInfo(foundObject, configuredAttributes, storageSize)
                    {
                        CkaPrivate = requiredAttributes[0].GetValueAsBool(),
                        CkaClass = (ulong)objectClass,
                        CkaKeyType = requiredAttributes[1].GetValueAsUlong(),
                        CkaLabel = requiredAttributes[2].GetValueAsString(),
                        CkaId = requiredAttributes[3].GetValueAsByteArray()
                    };

                    infos.Add(info);
                }
            }

            return infos;
        }

        private List<Pkcs11KeyInfo> ReadKeys()
        {
            List<Pkcs11KeyInfo> infos = new List<Pkcs11KeyInfo>();

            infos.AddRange(ReadKeys(CKO.CKO_PRIVATE_KEY, Pkcs11Admin.Instance.Config.PrivateKeyAttributes));
            infos.AddRange(ReadKeys(CKO.CKO_PUBLIC_KEY, Pkcs11Admin.Instance.Config.PublicKeyAttributes));
            infos.AddRange(ReadKeys(CKO.CKO_SECRET_KEY, Pkcs11Admin.Instance.Config.SecretKeyAttributes));
            // TODO - This is not good enough because some libraries may still return error for unknown object classes
            if (0 <= StringUtils.CompareCkVersions(Pkcs11Admin.Instance.Library.Info.CryptokiVersion, "2.20"))
                infos.AddRange(ReadKeys(CKO.CKO_OTP_KEY, Pkcs11Admin.Instance.Config.OtpKeyAttributes));

            return infos;
        }

        private List<Pkcs11DomainParamsInfo> ReadDomainParams()
        {
            List<Pkcs11DomainParamsInfo> infos = new List<Pkcs11DomainParamsInfo>();

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> searchTemplate = new List<IObjectAttribute>();
                searchTemplate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_DOMAIN_PARAMETERS));

                List<IObjectHandle> foundObjects = session.FindAllObjects(searchTemplate);
                foreach (IObjectHandle foundObject in foundObjects)
                {
                    // Read attributes required for sane object presentation
                    List<ulong> attributes = new List<ulong>();
                    attributes.Add((ulong)CKA.CKA_PRIVATE);
                    attributes.Add((ulong)CKA.CKA_KEY_TYPE);
                    attributes.Add((ulong)CKA.CKA_LABEL);

                    List<IObjectAttribute> requiredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read attributes configured for specific object class and type
                    attributes = new List<ulong>();
                    foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.DomainParamsAttributes.CommonAttributes)
                        attributes.Add(classAttribute.Value);
                    ulong keyType = requiredAttributes[1].GetValueAsUlong();
                    if (Pkcs11Admin.Instance.Config.DomainParamsAttributes.TypeSpecificAttributes.ContainsKey(keyType))
                        foreach (ClassAttribute classAttribute in Pkcs11Admin.Instance.Config.DomainParamsAttributes.TypeSpecificAttributes[keyType])
                            attributes.Add(classAttribute.Value);

                    List<IObjectAttribute> configuredAttributes = session.GetAttributeValue(foundObject, attributes);

                    // Read object storage size
                    ulong? storageSize = ReadObjectSize(session, foundObject);

                    // Construct info object
                    Pkcs11DomainParamsInfo info = new Pkcs11DomainParamsInfo(foundObject, configuredAttributes, storageSize)
                    {
                        CkaPrivate = requiredAttributes[0].GetValueAsBool(),
                        CkaKeyType = requiredAttributes[1].GetValueAsUlong(),
                        CkaLabel = requiredAttributes[2].GetValueAsString()
                    };

                    infos.Add(info);
                }
            }

            return infos;
        }

        private ulong? ReadObjectSize(ISession session, IObjectHandle objectHandle)
        {
            ulong? size = null;

            try
            {
                size = session.GetObjectSize(objectHandle);
            }
            catch
            {

            }

            return size;
        }

        private Dictionary<CKM, List<CKK>> GetKnownKeyGenerationMechanisms(TypeAttributes typeSpecificAttributes)
        {
            Dictionary<CKM, List<CKK>> knownMechanisms = new Dictionary<CKM, List<CKK>>();

            foreach (KeyValuePair<ulong, ClassAttributes> typeAttributes in typeSpecificAttributes)
            {
                CKK keyType = (CKK)typeAttributes.Key;
                CKM? mechanism = typeAttributes.Value.KeyGenerationMechanism;
                if (mechanism != null)
                {
                    if (!knownMechanisms.ContainsKey(mechanism.Value))
                        knownMechanisms.Add(mechanism.Value, new List<CKK>() { keyType });
                    else
                        knownMechanisms[mechanism.Value].Add(keyType);
                }
            }

            return knownMechanisms;
        }

        public List<CKK> GetGeneratableAsymmetricKeyTypes()
        {
            HashSet<CKK> keyTypes = new HashSet<CKK>();

            Dictionary<CKM, List<CKK>> knownMechanisms = GetKnownKeyGenerationMechanisms(Pkcs11Admin.Instance.Config.PrivateKeyAttributes.TypeSpecificAttributes);
            
            foreach (Pkcs11MechanismInfo mechanismInfo in Mechanisms)
            {
                if (mechanismInfo.GenerateKeyPair && knownMechanisms.ContainsKey(mechanismInfo.Mechanism))
                {
                    foreach (CKK keyType in knownMechanisms[mechanismInfo.Mechanism])
                    {
                        if (!keyTypes.Contains(keyType))
                            keyTypes.Add(keyType);
                    }
                }
            }

            return new List<CKK>(keyTypes);
        }

        public List<CKK> GetGeneratableSymmetricKeyTypes()
        {
            HashSet<CKK> keyTypes = new HashSet<CKK>();

            Dictionary<CKM, List<CKK>> knownMechanisms = GetKnownKeyGenerationMechanisms(Pkcs11Admin.Instance.Config.SecretKeyAttributes.TypeSpecificAttributes);

            foreach (Pkcs11MechanismInfo mechanismInfo in Mechanisms)
            {
                if (mechanismInfo.Generate && knownMechanisms.ContainsKey(mechanismInfo.Mechanism))
                {
                    foreach (CKK keyType in knownMechanisms[mechanismInfo.Mechanism])
                    {
                        if (!keyTypes.Contains(keyType))
                            keyTypes.Add(keyType);
                    }
                }
            }

            return new List<CKK>(keyTypes);
        }

        #endregion

        public void InitToken(string soPin, string label)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession != null)
                throw new Exception("Authenticated session exists");

            _slot.InitToken(soPin, label);
        }

        public string Login(CKU userType, byte[] pin)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession != null)
            {
                return authenticatedAlready;
                //throw new Exception("Authenticated session already exists");
            }

            try
            {
                _authenticatedSession = _slot.OpenSession(SessionType.ReadWrite);
            } catch (Exception ex)
            {
                return connectToCardUnsuccessfully;
            }

            try
            {
                _authenticatedSession.Login(userType, pin);
                return authenticatedSuccessfully;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                bool isPINLocked = ex.Message.Contains("CKR_PIN_LOCKED");
                bool isPINIncorrected = ex.Message.Contains("CKR_PIN_INCORRECT");
                _authenticatedSession.Dispose();
                _authenticatedSession = null;

                return isPINLocked ? theCardIsBlocked : isPINIncorrected ? thePINIsInCorrect : authenticatedUnSuccessfully;
                //[thuan] update here
                //throw;
            }
        }

        public void ChangePin(string oldPin, string newPin)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession == null)
                throw new Exception("Authenticated session does not exist");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.SetPin(oldPin, newPin);
        }

        public void InitPin(string pin)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession == null)
                throw new Exception("Authenticated session does not exist");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.InitPin(pin);
        }

        public bool InitPinUser(string pin)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession == null)
            {
                //throw new Exception("Authenticated session does not exist");
                return false;
            }
            try
            {
                using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.InitPin(pin);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Logout()
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession == null)
                throw new Exception("Authenticated session does not exist");

            try
            {
                _authenticatedSession.Logout();
            }
            finally
            {
                _authenticatedSession.Dispose();
                _authenticatedSession = null;
            }
        }

        public bool LogoutUser()
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (_authenticatedSession == null)
            {
                //throw new Exception("Authenticated session does not exist");
                return true;
            }

            try
            {
                _authenticatedSession.Logout();
            }
            catch(Exception)
            {
                try
                {
                    _authenticatedSession.Dispose();
                    _authenticatedSession = null;
                    return true;
                } catch(Exception)
                {
                    return true;
                }
            }
            return true;
        }

        public void SaveObjectAttributes(Pkcs11ObjectInfo objectInfo, List<IObjectAttribute> objectAttributes)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (objectInfo == null)
                throw new ArgumentNullException("objectInfo");

            if (objectAttributes == null)
                throw new ArgumentNullException("objectAttributes");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.SetAttributeValue(objectInfo.ObjectHandle, objectAttributes);
        }

        public List<IObjectAttribute> LoadObjectAttributes(Pkcs11ObjectInfo objectInfo, List<ulong> attributes)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (objectInfo == null)
                throw new ArgumentNullException("objectInfo");

            if (attributes == null)
                throw new ArgumentNullException("objectAttributes");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                return session.GetAttributeValue(objectInfo.ObjectHandle, attributes);
        }

        public void DeleteObject(Pkcs11ObjectInfo objectInfo)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (objectInfo == null)
                throw new ArgumentNullException("objectInfo");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.DestroyObject(objectInfo.ObjectHandle);
        }

        public void CreateObject(List<IObjectAttribute> objectAttributes)
        {
            if (objectAttributes == null)
                throw new ArgumentNullException("objectAttributes");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
                session.CreateObject(objectAttributes);
        }

        public List<Tuple<IObjectAttribute, ClassAttribute>> ImportDataObject(string fileName, byte[] fileContent)
        {
            IObjectAttributeFactory objectAttributeFactory = Pkcs11Admin.Instance.Factories.ObjectAttributeFactory;

            List<Tuple<IObjectAttribute, ClassAttribute>> objectAttributes = StringUtils.GetCreateDefaultAttributes(Pkcs11Admin.Instance.Config.DataObjectAttributes, null);

            bool ckaLabelFound = false;
            bool ckaValueFound = false;

            for (int i = 0; i < objectAttributes.Count; i++)
            {
                IObjectAttribute objectAttribute = objectAttributes[i].Item1;
                ClassAttribute classAttribute = objectAttributes[i].Item2;

                if (objectAttribute.Type == (ulong)CKA.CKA_LABEL)
                {
                    objectAttributes[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_LABEL, fileName), classAttribute);
                    ckaLabelFound = true;
                }
                else if (objectAttribute.Type == (ulong)CKA.CKA_VALUE)
                {
                    objectAttributes[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_VALUE, fileContent), classAttribute);
                    ckaValueFound = true;
                }
            }

            if (!ckaLabelFound)
                throw new Exception("TODO - ClassAttributeNotFoundException");

            if (!ckaValueFound)
                throw new Exception("TODO - ClassAttributeNotFoundException");

            return objectAttributes;
        }

        public void ExportDataObject(Pkcs11DataObjectInfo objectInfo, out string fileName, out byte[] fileContent)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (objectInfo == null)
                throw new ArgumentNullException("objectInfo");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<ulong> attributes = new List<ulong>();
                attributes.Add((ulong)CKA.CKA_LABEL);
                attributes.Add((ulong)CKA.CKA_VALUE);

                List<IObjectAttribute> objectAttributes = session.GetAttributeValue(objectInfo.ObjectHandle, attributes);

                fileName = objectAttributes[0].GetValueAsString();
                fileName = (!string.IsNullOrEmpty(fileName)) ? Utils.NormalizeFileName(fileName) : "data_object";
                fileContent = objectAttributes[1].GetValueAsByteArray();
            }
        }

        public List<Item> getListOfCertItems(string fileName, byte[] fileContent)
        {
            List<Item> result = new List<Item>();

            List<Org.BouncyCastle.X509.X509Certificate> allCerts = new List<Org.BouncyCastle.X509.X509Certificate>();
            if (fileName.Contains(".pfx") || fileName.Contains(".p12"))
            {
                string certPass = "lamgicopass";
                // Create a collection object and populate it using the PFX file
                X509Certificate2Collection collection = new X509Certificate2Collection();
                collection.Import(fileContent, certPass, X509KeyStorageFlags.Exportable);

                foreach (X509Certificate2 cert in collection)
                {
                    Item itemTemp = new Item();
                    Console.WriteLine("Subject is: '{0}'", cert.Subject);
                    Console.WriteLine("Issuer is:  '{0}'", cert.Issuer);
                    itemTemp.cert = (Org.BouncyCastle.Security.DotNetUtilities.FromX509Certificate(cert));
                    // RSA rsapublic = RSA.Create();
                    RSA rsaprivate = RSA.Create();
                    // rsapublic = (RSA)cert.PublicKey.Key;
                    rsaprivate = (RSA)cert.PrivateKey;
                    RSAParameters paramprivate = rsaprivate.ExportParameters(true);
                    itemTemp.keys.Add(paramprivate);
                    result.Add(itemTemp);
                }
            }
            else
            {
                X509CertificateParser x509CertificateParser = new X509CertificateParser();
                Org.BouncyCastle.X509.X509Certificate x509Certificate = x509CertificateParser.ReadCertificate(fileContent);
                Item itemTemp = new Item();
                itemTemp.cert = x509Certificate;
            }

            return result;
        }

        public List<X509Certificate2> getListOfCert(string fileName, byte[] fileContent)
        {

            List<X509Certificate2> allCerts = new List<X509Certificate2>();
            if (fileName.Contains(".pfx") || fileName.Contains(".p12"))
            {
                string certPass = "lamgicopass";
                // Create a collection object and populate it using the PFX file
                X509Certificate2Collection collection = new X509Certificate2Collection();
                collection.Import(fileContent, certPass, X509KeyStorageFlags.Exportable);

                foreach (X509Certificate2 cert in collection)
                {
                    Console.WriteLine("Subject is: '{0}'", cert.Subject);
                    Console.WriteLine("Issuer is:  '{0}'", cert.Issuer);
                    allCerts.Add(cert);
                }
            }
            else
            {
                X509CertificateParser x509CertificateParser = new X509CertificateParser();
                Org.BouncyCastle.X509.X509Certificate x509Certificate = x509CertificateParser.ReadCertificate(fileContent);
                allCerts.Add(new X509Certificate2(x509Certificate.GetEncoded()));
            }

            return allCerts;
        }

        public List<List<Tuple<IObjectAttribute, ClassAttribute>>> ImportCertificate(string fileName, byte[] fileContent)
        {

            IObjectAttributeFactory objectAttributeFactory = Pkcs11Admin.Instance.Factories.ObjectAttributeFactory;
            List<Item> allCerts = getListOfCertItems(fileName, fileContent);

            List<List<Tuple<IObjectAttribute, ClassAttribute>>> allObjectAttributes = new List<List<Tuple<IObjectAttribute, ClassAttribute>>>();

            foreach(Item each in allCerts)
            {
                List<Tuple<IObjectAttribute, ClassAttribute>> objectAttributeCert = StringUtils.GetCreateDefaultAttributes(Pkcs11Admin.Instance.Config.CertificateAttributes, (ulong)CKC.CKC_X_509);
                List<Tuple<IObjectAttribute, ClassAttribute>> objectAttributeKey = StringUtils.GetCreateDefaultAttributes(Pkcs11Admin.Instance.Config.PrivateKeyAttributes, (ulong)CKC.CKC_X_509);

                for (int i = 0; i < objectAttributeCert.Count; i++)
                {
                    IObjectAttribute objectAttribute = objectAttributeCert[i].Item1;
                    ClassAttribute classAttribute = objectAttributeCert[i].Item2;
                    Console.WriteLine("ImportCertificate objectAttribute.GetType()=====" + objectAttribute.Type.ToString());
                    if (objectAttribute.Type == (ulong)CKA.CKA_LABEL)
                    {
                        string label = fileName;
                        Dictionary<string, List<string>> subject = Utils.ParseX509Name(each.cert.SubjectDN);
                        if (subject.ContainsKey(X509ObjectIdentifiers.CommonName.Id) && (subject[X509ObjectIdentifiers.CommonName.Id].Count > 0))
                            label = subject[X509ObjectIdentifiers.CommonName.Id][0];

                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_LABEL, label), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_START_DATE)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_START_DATE, each.cert.NotBefore), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_END_DATE)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_END_DATE, each.cert.NotAfter), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_SUBJECT)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_SUBJECT, each.cert.SubjectDN.GetDerEncoded()), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_ID)
                    {
                        byte[] thumbPrint = null;
                        using (SHA1Managed sha1Managed = new SHA1Managed())
                            thumbPrint = sha1Managed.ComputeHash(each.cert.GetEncoded());

                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_ID, thumbPrint), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_ISSUER)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_ISSUER, each.cert.IssuerDN.GetDerEncoded()), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_SERIAL_NUMBER)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_SERIAL_NUMBER, new DerInteger(each.cert.SerialNumber).GetDerEncoded()), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_VALUE)
                    {
                        objectAttributeCert[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_VALUE, each.cert.GetEncoded()), classAttribute);
                    }
                }

                for (int i = 0; i < objectAttributeKey.Count; i++)
                {
                    IObjectAttribute objectAttribute = objectAttributeKey[i].Item1;
                    ClassAttribute classAttribute = objectAttributeKey[i].Item2;
                    Console.WriteLine("ImportCertificate objectAttribute.GetType()=====" + objectAttribute.Type.ToString());
                    if (objectAttribute.Type == (ulong)CKA.CKA_LABEL)
                    {
                        string label = fileName;
                        Dictionary<string, List<string>> subject = Utils.ParseX509Name(each.cert.SubjectDN);
                        if (subject.ContainsKey(X509ObjectIdentifiers.CommonName.Id) && (subject[X509ObjectIdentifiers.CommonName.Id].Count > 0))
                            label = subject[X509ObjectIdentifiers.CommonName.Id][0];

                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_LABEL, label), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_SUBJECT)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_SUBJECT, each.cert.SubjectDN.GetDerEncoded()), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_MODULUS)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_MODULUS, each.keys[0].Modulus), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_PUBLIC_EXPONENT)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_PUBLIC_EXPONENT, each.keys[0].Exponent), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_PRIVATE_EXPONENT)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_PRIVATE_EXPONENT, each.keys[0].D), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_COEFFICIENT)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_COEFFICIENT, each.keys[0].InverseQ), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_EXPONENT_1)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_EXPONENT_1, each.keys[0].DP), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_EXPONENT_2)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_EXPONENT_2, each.keys[0].DQ), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_PRIME_1)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_PRIME_1, each.keys[0].P), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_PRIME_2)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_PRIME_2, each.keys[0].Q), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_MODIFIABLE)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_MODIFIABLE, false), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_DERIVE)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_DERIVE, false), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_SENSITIVE)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_SENSITIVE, true), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_SIGN_RECOVER)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_SIGN_RECOVER, true), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_UNWRAP)
                    {
                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_UNWRAP, false), classAttribute);
                    }
                    else if (objectAttribute.Type == (ulong)CKA.CKA_ID)
                    {
                        byte[] thumbPrint = null;
                        using (SHA1Managed sha1Managed = new SHA1Managed())
                            thumbPrint = sha1Managed.ComputeHash(each.cert.GetEncoded());

                        objectAttributeKey[i] = new Tuple<IObjectAttribute, ClassAttribute>(objectAttributeFactory.Create(CKA.CKA_ID, thumbPrint), classAttribute);
                    }

                }

                allObjectAttributes.Add(objectAttributeCert);
                allObjectAttributes.Add(objectAttributeKey);

            }


            return allObjectAttributes;
        }

        public void ExportCertificate(Pkcs11CertificateInfo objectInfo, out string fileName, out byte[] fileContent)
        {
            if (this._disposed)
                throw new ObjectDisposedException(this.GetType().FullName);

            if (objectInfo == null)
                throw new ArgumentNullException("objectInfo");

            fileName = (!string.IsNullOrEmpty(objectInfo.CkaLabel)) ? Utils.NormalizeFileName(objectInfo.CkaLabel + ".cer") : "certificate.cer";
            fileContent = objectInfo.CkaValue;
        }

        public void GenerateSymmetricKey(CKK keyType, List<IObjectAttribute> objectAttributes)
        {
            if (objectAttributes == null)
                throw new ArgumentNullException("objectAttributes");

            if (!Pkcs11Admin.Instance.Config.SecretKeyAttributes.TypeSpecificAttributes.ContainsKey((ulong)keyType))
                throw new Exception("Unsupported key type");

            CKM? mechanismType = Pkcs11Admin.Instance.Config.SecretKeyAttributes.TypeSpecificAttributes[(ulong)keyType].KeyGenerationMechanism;
            if (mechanismType == null)
                throw new Exception("Key generation mechanism not specified");

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            using (IMechanism mechanism = session.Factories.MechanismFactory.Create(mechanismType.Value))
                session.GenerateKey(mechanism, objectAttributes);
        }

        public void GenerateAsymmetricKeyPair(CKK keyType, List<IObjectAttribute> privateKeyObjectAttributes, List<IObjectAttribute> publicKeyObjectAttributes)
        {
            if (privateKeyObjectAttributes == null)
                throw new ArgumentNullException("privateKeyObjectAttributes");

            if (publicKeyObjectAttributes == null)
                throw new ArgumentNullException("publicKeyObjectAttributes");

            if (!Pkcs11Admin.Instance.Config.PrivateKeyAttributes.TypeSpecificAttributes.ContainsKey((ulong)keyType))
                throw new Exception("Unsupported key type");

            CKM? mechanismType = Pkcs11Admin.Instance.Config.PrivateKeyAttributes.TypeSpecificAttributes[(ulong)keyType].KeyGenerationMechanism;
            if (mechanismType == null)
                throw new Exception("Key generation mechanism not specified");

            IObjectHandle privateKeyHandle = null;
            IObjectHandle publicKeyHandle = null;

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            using (IMechanism mechanism = session.Factories.MechanismFactory.Create(mechanismType.Value))
                session.GenerateKeyPair(mechanism, publicKeyObjectAttributes, privateKeyObjectAttributes, out publicKeyHandle, out privateKeyHandle);
        }

        private AsymmetricKeyParameter GetPubKeyParams(Pkcs11KeyInfo privKeyInfo, Pkcs11KeyInfo pubKeyInfo)
        {
            if (privKeyInfo != null && privKeyInfo.CkaKeyType != (ulong)CKK.CKK_RSA)
                throw new Exception("Unsupported key type");

            if (pubKeyInfo != null && pubKeyInfo.CkaKeyType != (ulong)CKK.CKK_RSA)
                throw new Exception("Unsupported key type");

            Pkcs11KeyInfo rsaKeyInfo = (privKeyInfo != null) ? privKeyInfo : pubKeyInfo;

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            {
                List<IObjectAttribute> attributes = session.GetAttributeValue(rsaKeyInfo.ObjectHandle, new List<CKA> { CKA.CKA_MODULUS, CKA.CKA_PUBLIC_EXPONENT });
                BigInteger modulus = new BigInteger(1, attributes[0].GetValueAsByteArray());
                BigInteger publicExponent = new BigInteger(1, attributes[1].GetValueAsByteArray());
                return new RsaKeyParameters(false, modulus, publicExponent);
            }
        }

        public void GenerateCsr(Pkcs11KeyInfo privKeyInfo, Pkcs11KeyInfo pubKeyInfo, DnEntry[] dnEntries, HashAlgorithm hashAlgorithm, out string fileName, out byte[] fileContent)
        {
            string signatureAlgorithmOid = hashAlgorithm.SignatureAlgorithmOid[(CKK)privKeyInfo.CkaKeyType];
            X509Name x509Name = Utils.CreateX509Name(dnEntries);
            AsymmetricKeyParameter publicKeyParameters = GetPubKeyParams(privKeyInfo, pubKeyInfo);

            Pkcs10CertificationRequestDelaySigned pkcs10 = new Pkcs10CertificationRequestDelaySigned(signatureAlgorithmOid, x509Name, publicKeyParameters, null);

            byte[] dataToSign = pkcs10.GetDataToSign();
            byte[] digest = hashAlgorithm.ComputeDigest(dataToSign);
            byte[] digestInfo = Utils.CreateDigestInfo(digest, hashAlgorithm.Oid);
            byte[] signature = null;

            using (ISession session = _slot.OpenSession(SessionType.ReadWrite))
            using (IMechanism mechanism = session.Factories.MechanismFactory.Create(CKM.CKM_RSA_PKCS))
                signature = session.Sign(mechanism, privKeyInfo.ObjectHandle, digestInfo);

            pkcs10.SignRequest(new DerBitString(signature));
            byte[] csr = pkcs10.GetDerEncoded();

            fileName = (!string.IsNullOrEmpty(privKeyInfo.CkaLabel)) ? Utils.NormalizeFileName(privKeyInfo.CkaLabel + ".csr") : "pkcs10.csr";
            fileContent = csr;
        }

        public bool IsVulnerableToROCA(Pkcs11CertificateInfo certificateInfo)
        {
            X509CertificateParser x509CertificateParser = new X509CertificateParser();
            Org.BouncyCastle.X509.X509Certificate x509Certificate = x509CertificateParser.ReadCertificate(certificateInfo.CkaValue);
            RsaKeyParameters rsaKeyParameters = x509Certificate.GetPublicKey() as RsaKeyParameters;
            return RocaVulnerabilityTester.IsVulnerable(rsaKeyParameters);
        }

        public bool IsVulnerableToROCA(Pkcs11KeyInfo keyInfo)
        {
            RsaKeyParameters rsaKeyParameters = null;

            if (keyInfo.CkaClass == (ulong)CKO.CKO_PRIVATE_KEY && keyInfo.CkaKeyType == (ulong)CKK.CKK_RSA)
                rsaKeyParameters = GetPubKeyParams(keyInfo, null) as RsaKeyParameters;
            else if (keyInfo.CkaClass == (ulong)CKO.CKO_PUBLIC_KEY && keyInfo.CkaKeyType == (ulong)CKK.CKK_RSA)
                rsaKeyParameters = GetPubKeyParams(null, keyInfo) as RsaKeyParameters;
            else
                throw new Exception("Unsupported key type");

            return RocaVulnerabilityTester.IsVulnerable(rsaKeyParameters);
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (!this._disposed)
                {
                    if (disposing)
                    {
                        // Dispose managed objects

                        if (_authenticatedSession != null)
                        {
                            _authenticatedSession.Dispose();
                            _authenticatedSession = null;
                        }
                    }

                    // Dispose unmanaged objects

                    _disposed = true;
                }
            }
            catch(Exception)
            {

            }
        }

        ~Pkcs11Slot()
        {
            Dispose(false);
        }

        #endregion
    }

    public class Item
    {
        public List<RSAParameters> keys { get; set; }
        public Org.BouncyCastle.X509.X509Certificate cert { get; set; }

        public Item()
        {
            keys = new List<RSAParameters>();
            cert = null;
        }
    }
}
