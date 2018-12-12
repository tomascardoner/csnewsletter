using System;
using System.Data;
using System.Windows.Forms;

namespace CSNewsletter
{
    public partial class formMain : Form
    {
        bool mEditMode = false;
        Article mArticle = null;

        public formMain()
        {
            InitializeComponent();

            this.Text = CardonerSistemas.My.Application.Info.Title;

            FillAndRefreshLists.NewslettersComboBox(ref comboboxNewsletter, true);
            
            ChangeMode();
        }

        private void ChangeMode()
        {
            comboboxNewsletter.Enabled = !mEditMode;
            listboxArticles.Enabled = !mEditMode;
            buttonArticleAdd.Enabled = !mEditMode;
            buttonArticleEdit.Enabled = !mEditMode;
            buttonArticleDelete.Enabled = !mEditMode;

            textboxArticleID.ReadOnly = !mEditMode;
            textboxTitle.ReadOnly = !mEditMode;
            textboxImageName.ReadOnly = !mEditMode;
            buttonImageName.Visible = mEditMode;
            textboxBody.ReadOnly = !mEditMode;
            checkboxPhotoGalleryUse.Enabled = mEditMode;
            textboxPhotoGalleryID.ReadOnly = !mEditMode;
            updownOrderNumber.Enabled = mEditMode;

            buttonOk.Visible = mEditMode;
            buttonCancel.Visible = mEditMode;
        }

        private void NewsletterChange(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            FillAndRefreshLists.ArticlesListBox(ref listboxArticles, true, Convert.ToInt16(comboboxNewsletter.SelectedValue));
        }

        private void ArticleChange(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedValue != null)
            {
                mArticle = new Article();
                mArticle.Database = Program.Database;
                if (mArticle.Load(Convert.ToInt16(comboboxNewsletter.SelectedValue), listboxArticles.SelectedValue.ToString()))
                {
                    SetDataToControls(mArticle);
                }
                else
                {
                    BlankControls();
                }
            }
            else
            {
                BlankControls();
            }
        }

        private void ArticleAdd(object sender, EventArgs e)
        {
            if (comboboxNewsletter.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna Newsletter seleccionada.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            mArticle = new Article();
            mArticle.Database = Program.Database;
            BlankControls();
            mEditMode = true;
            ChangeMode();
        }

        private void ArticleEdit(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedItem is null)
            {
                MessageBox.Show("No hay ningún Artículo seleccionado para poder editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            mEditMode = true;
            ChangeMode();
        }

        private void ArticleDelete(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedItem is null)
            {
                MessageBox.Show("No hay ningún Artículo seleccionado para poder eliminar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listboxArticles.Focus();
                return;
            }

            if (MessageBox.Show(string.Format("Se eliminará el Artículo seleccionado.{0}{0}ID: {1}{0}Título: {2}{0}{0}¿Desea continuar?", Environment.NewLine, textboxArticleID.Text, textboxTitle.Text), CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mArticle.Delete())
                {
                    BlankControls();
                    RefreshListBox();
                }
            }
            listboxArticles.Focus();
        }

        private void BlankControls()
        {
            textboxArticleID.Text = "";
            textboxTitle.Text = "";
            textboxImageName.Text = "";
            textboxBody.Text = "";
            checkboxPhotoGalleryUse.Checked = false;
            textboxPhotoGalleryID.Text = "";
            updownOrderNumber.Value = 0;
        }

        private void TextboxsGotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void SetDataToControls(Article article)
        {            
            textboxArticleID.Text = article.ID;
            textboxTitle.Text = article.Title;
            textboxImageName.Text = article.ImageName;
            textboxBody.Text = article.Body;
            checkboxPhotoGalleryUse.Checked = article.PhotoGalleryUse;
            textboxPhotoGalleryID.Text = article.PhotoGalleryID;
            updownOrderNumber.Value = article.OrderNumber;
        }

        private void CancelClick(object sender, EventArgs e)
        {
            mEditMode = false;
            ChangeMode();
            ArticleChange(listboxArticles, new EventArgs());
        }

        private void OkClick(object sender, EventArgs e)
        {
            if (textboxArticleID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el ID del Artículo.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxArticleID.Focus();
                return;
            }
            if (textboxTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Título del Artículo.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxTitle.Focus();
                return;
            }
            if (mArticle.IsNew)
            {
                mArticle.NewsletterID = Convert.ToInt16(comboboxNewsletter.SelectedValue);
            }
            mArticle.ID = textboxArticleID.Text;
            mArticle.Title = textboxTitle.Text;
            mArticle.ImageName = textboxImageName.Text;
            mArticle.Body = textboxBody.Text;
            mArticle.PhotoGalleryUse = checkboxPhotoGalleryUse.Checked;
            mArticle.PhotoGalleryID = textboxPhotoGalleryID.Text;
            mArticle.OrderNumber = Convert.ToByte(updownOrderNumber.Value);

            if (mArticle.Update())
            {
                mEditMode = false;
                ChangeMode();
                RefreshListBox();
            }
        }

        private void BodyFocusEnter(object sender, EventArgs e)
        {
            textboxBody.SelectAll();
            this.AcceptButton = null;
        }

        private void BodyFocusLeave(object sender, EventArgs e)
        {
            this.AcceptButton = buttonOk;
        }
    }
}
