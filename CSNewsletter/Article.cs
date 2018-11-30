using System;
using System.Data;
using System.Data.OleDb;

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
        public byte OrderNumber
        {
            get => _orderNumber;
            set
            {
                if (value != _orderNumber)
                {
                    _isDirty = true;
                    _orderNumber = value;
                }
            }
        }

        public CardonerSistemas.Database_ADO_OleDb Database { get; set; }
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
        private byte _orderNumber;

        #endregion

        public Article()
        {
            InitializeValues();
        }

        public Article(ref CardonerSistemas.Database_ADO_OleDb database)
        {
            Database = database;
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
            _orderNumber = 0;
        }

        public void MakeDirty()
        {
            _isDirty = true;
            return;
        }

        public bool Load(short newsletterID, string iD)
        {
            InitializeValues();

            OleDbDataReader dataReader = null;

            if (Database.OpenDataReader(ref dataReader, string.Format("SELECT * FROM NewsletterArticle WHERE NewsletterID = {0} AND ID = '{1}'", newsletterID, iD), CommandType.Text, CommandBehavior.SingleRow, string.Format("Error al leer el Artículo de la base de datos.{0}{0}NewsletterID: {1}{0}ID: {2}", Environment.NewLine, _newsletterID, _iD)))
            {
                return GetDataFromRecordset(ref dataReader);
            }
            else
            {
                return false;
            }
        }

        public bool GetDataFromRecordset(ref OleDbDataReader dataReader)
        {
            if (!_raiseExceptionWhenNotMatch && !dataReader.HasRows)
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
                    dataReader.Read();
                    _newsletterID = Convert.ToInt16 (dataReader["NewsletterID"]);
                    _iD = dataReader["ID"].ToString();
                    _title = dataReader["Title"].ToString();
                    _imageName = dataReader["ImageName"].ToString();
                    _body = dataReader["Body"].ToString();
                    _photoGalleryUse = Convert.ToBoolean(dataReader["PhotoGalleryUse"]);
                    _photoGalleryID = dataReader["PhotoGalleryID"].ToString();
                    _orderNumber = (dataReader["OrderNumber"] == System.DBNull.Value ? Convert.ToByte(0) : Convert.ToByte(dataReader["OrderNumber"]));

                    return true;
                }
                catch (Exception ex)
                {
                    CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al obtener los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {2}", Environment.NewLine, _newsletterID, _iD));
                    return false;
                }
            }
        }

        public bool Copy()
        {
            if (Load(_newsletterID, _iD))
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
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                DataSet dataSet = null;
                if (Database.OpenDataSet(ref dataAdapter, ref dataSet, string.Format("SELECT * FROM NewsletterArticle WHERE NewsletterID = {0} AND ID = '{1}'", _newsletterID, _iD), "NewsletterArticle", string.Format("Error al obtener el Artículo de la Base de Datos.{0}{0}NewsletterID: {1}{0}ID: {1}", Environment.NewLine, _newsletterID, _iD)))
                {
                    DataRow dataRow = null;
                    if (_isNew)
                    {
                        dataRow = dataSet.Tables["NewsletterArticle"].NewRow();
                        dataRow["NewsletterID"] = _newsletterID;
                    }
                    else
                    {
                        dataRow = dataSet.Tables["NewsletterArticle"].Rows[0];
                    }
                    dataRow["ID"] = _iD;
                    dataRow["Title"] = _title.Trim().Length == 0 ? null : _title.Trim();
                    dataRow["Body"] = _body.Trim().Length == 0 ? null : _body.Trim();
                    dataRow["ImageName"] = _imageName.Trim().Length == 0 ? null : _imageName.Trim();
                    dataRow["PhotoGalleryUse"] = _photoGalleryUse;
                    dataRow["PhotoGalleryID"] = _photoGalleryID.Trim().Length == 0 ? null : _photoGalleryID.Trim();
                    if (_orderNumber == 0)
                    {
                        dataRow["OrderNumber"] = DBNull.Value;
                    }
                    else
                    {
                        dataRow["OrderNumber"] = _orderNumber;
                    }

                    if (_isNew)
                    {
                        dataSet.Tables["NewsletterArticle"].Rows.Add(dataRow);
                    }
                    dataAdapter.Update(dataSet, "NewsletterArticle");
                }
                return true;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ref ex, string.Format("Error al actualizar los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {2}", Environment.NewLine, _newsletterID, _iD));
                return false;
            }
        }

        public bool Delete()
        {
            return Database.Execute(string.Format("DELETE FROM NewsletterArticle WHERE NewsletterID = {0} AND ID = '{1}'", _newsletterID, _iD), CommandType.Text, string.Format("Error al eliminar los datos del Artículo.{0}{0}NewsletterID: {1}{0}ID: {2}", Environment.NewLine, _newsletterID, _iD));
        }
    }
}
