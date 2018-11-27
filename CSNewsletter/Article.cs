using System;

namespace CSNewsletter
{
    class Article
    {
        #region "Declarations"

        // Public properties
        public short NewsletterID
        {
            get => _newsletterID;
            set
            {
                if (value != _newsletterID)
                {
                    _isDirty = true;
                    _newsletterID = value;
                }
            }
        }
        public string ID
        {
            get => _iD;
            set
            {
                if (value != _iD)
                {
                    _isDirty = true;
                    _iD = value;
                }
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                if (value != _title)
                {
                    _isDirty = true;
                    _title = value;
                }
            }
        }
        public string ImageName
        {
            get => _imageName;
            set
            {
                if (value != _imageName)
                {
                    _isDirty = true;
                    _imageName = value;
                }
            }
        }
        public string Body
        {
            get => _body;
            set
            {
                if (value != _body)
                {
                    _isDirty = true;
                    _body = value;
                }
            }
        }
        public bool PhotoGalleryUse
        {
            get => _photoGalleryUse;
            set
            {
                if (value != _photoGalleryUse)
                {
                    _isDirty = true;
                    _photoGalleryUse = value;
                }
            }
        }
        public string PhotoGalleryID
        {
            get => _photoGalleryID;
            set
            {
                if (value != _photoGalleryID)
                {
                    _isDirty = true;
                    _photoGalleryID = value;
                }
            }
        }
        public byte Order
        {
            get => _order;
            set
            {
                if (value != _order)
                {
                    _isDirty = true;
                    _order = value;
                }
            }
        }

        public bool IsNew => _isNew;
        public bool RaiseExceptionWhenNotMatch { get => _raiseExceptionWhenNotMatch; set => _raiseExceptionWhenNotMatch = value; }
        public bool NoMatch => _noMatch;

        // Internal variables
        private bool _isNew;
        private bool _isDirty;
        private bool _raiseExceptionWhenNotMatch;
        private bool _noMatch;

        // Properties variables
        private short _newsletterID;
        private string _iD;
        private string _title;
        private string _imageName;
        private string _body;
        private bool _photoGalleryUse;
        private string _photoGalleryID;
        private byte _order;

        #endregion

        public Article()
        {
            InitializeValues();
        }

        private void InitializeValues()
        {
            _isNew = true;
            _isDirty = false;
            _noMatch = false;
            _raiseExceptionWhenNotMatch = true;

            _newsletterID = 0;
            _iD = "";
            _title = "";
            _imageName = "";
            _body = "";
            _photoGalleryUse = false;
            _photoGalleryID = "";
            _order = 0;
        }

        public void MakeDirty()
        {
            _isDirty = true;
            return;
        }

        public bool Load()
        {
            InitializeValues();

            try
            {
                bool result;

                // open command for read data
                // open recordset
                //result = GetDataFromRecordset();
                result = true;

                return result;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al leer el Artículo de la base de datos.{0}{0}NewsletterID: {1}{0}ID: {1}", Environment.NewLine, _newsletterID, _iD));
                return false;
            }

        }

        public bool GetDataFromRecordset(ref System.Data.OleDb.OleDbDataReader drData)
        {
            if (!_raiseExceptionWhenNotMatch && !drData.HasRows)
            {
                _noMatch = true;
                return true;
            }
            else
            {
                _isNew = false;
                _isDirty = false;
                _noMatch = false;

                try
                {
                    drData.Read();
                    _newsletterID = Convert.ToInt16 (drData["NewsletterID"]);
                    _iD = drData["ID"].ToString();
                    _title = drData["Title"].ToString();
                    _imageName = drData["ImageName"].ToString();
                    _body = drData["Body"].ToString();
                    _photoGalleryUse = Convert.ToBoolean(drData["PhotoGalleryUse"]);
                    _photoGalleryID = drData["PhotoGalleryID"].ToString();
                    _order = Convert.ToByte(drData["Order"]);

                    return true;
                }
                catch (Exception ex)
                {
                    CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al obtener los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {1}", Environment.NewLine, _newsletterID, _iD));
                    return false;
                }
            }
        }

        public bool Copy()
        {
            if (Load())
            {
                _isNew = true;
                _isDirty = true;

                return true;
            }
            else
            { return false; }
        }

        public bool Update()
        {
            if (!_isDirty)
            {
                return true;
            }

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al actualizar los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {1}", Environment.NewLine, _newsletterID, _iD));
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al eliminar los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {1}", Environment.NewLine, _newsletterID, _iD));
                return false;
            }
        }
    }
}
