using Microsoft.EntityFrameworkCore;// add this
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicEFApp
{
    public partial class Home : Form
    {
        private MusicDBContext? dbContext;
        public Home()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new MusicDBContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Albums.Load();

            this.albumBindingSource.DataSource = dbContext.Albums.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

       
        private void AlbumsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var album = (Album)this.AlbumsGridView.CurrentRow.DataBoundItem;

                if (album != null)
                {
                    this.dbContext.Entry(album).Collection(e => e.Song).Load();
                }
            }
        }
    }
}
