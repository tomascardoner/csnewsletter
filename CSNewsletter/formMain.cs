using System;
using System.Data;
using System.Windows.Forms;

namespace CSNewsletter
{
    public partial class formMain : Form
    {
        bool mEditMode = false;

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
            updownOrder.Enabled = mEditMode;

            buttonOk.Visible = mEditMode;
            buttonCancel.Visible = mEditMode;
        }

        private void TextboxsGotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void ArticleAdd(object sender, EventArgs e)
        {

        }

        private void ArticleEdit(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedItem is null)
            {
                MessageBox.Show("No hay ningún Artículo seleccionado para poder editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ArticleDelete(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedItem is null)
            {
                MessageBox.Show("No hay ningún Artículo seleccionado para poder eliminar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show(string.Format("Se eliminará el Artículo seleccionado./n/nID: /nTítulo: /n/n¿Desea continuar?"), CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
            }
        }

        private void ArticlesSelectionChange(object sender, EventArgs e)
        {
            if (listboxArticles.SelectedIndex == -1)
            {
                BlankControls();
            }
            else
            { }
        }

        private void BlankControls()
        {
            textboxArticleID.Text = "";
            textboxTitle.Text = "";
            textboxImageName.Text = "";
            textboxBody.Text = "";
            checkboxPhotoGalleryUse.Checked = false;
            textboxPhotoGalleryID.Text = "";
            updownOrder.Value = 0;
        }

        private void SetControls()
        {
            textboxArticleID.Text = "";
            textboxTitle.Text = "";
            textboxImageName.Text = "";
            textboxBody.Text = "";
            checkboxPhotoGalleryUse.Checked = false;
            textboxPhotoGalleryID.Text = "";
            updownOrder.Value = 0;
        }

        private void NewsletterChange(object sender, EventArgs e)
        {
            FillAndRefreshLists.ArticlesListBox(ref listboxArticles, true, Convert.ToInt16(comboboxNewsletter.SelectedValue));
        }
    }
}
