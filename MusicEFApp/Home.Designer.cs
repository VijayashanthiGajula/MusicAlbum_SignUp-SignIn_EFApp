namespace MusicEFApp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AlbumsGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            albumBindingSource = new BindingSource(components);
            songBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            songIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            albumIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            albumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            songBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)AlbumsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // AlbumsGridView
            // 
            AlbumsGridView.AutoGenerateColumns = false;
            AlbumsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlbumsGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            AlbumsGridView.DataSource = albumBindingSource;
            AlbumsGridView.Location = new Point(12, 32);
            AlbumsGridView.Name = "AlbumsGridView";
            AlbumsGridView.RowHeadersWidth = 51;
            AlbumsGridView.Size = new Size(214, 188);
            AlbumsGridView.TabIndex = 0;
           // AlbumsGridView.CellContentClick += AlbumsGridView_CellContentClick;
            AlbumsGridView.SelectionChanged += AlbumsGridView_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // albumBindingSource
            // 
            albumBindingSource.DataSource = typeof(Album);
            // 
            // songBindingSource
            // 
            songBindingSource.DataMember = "Song";
            songBindingSource.DataSource = albumBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "AlbumId";
            dataGridViewTextBoxColumn1.HeaderText = "AlbumId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { songIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, albumIdDataGridViewTextBoxColumn, albumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = songBindingSource1;
            dataGridView1.Location = new Point(287, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 1;
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            songIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            songIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            albumIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            albumIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            albumDataGridViewTextBoxColumn.HeaderText = "Album";
            albumDataGridViewTextBoxColumn.MinimumWidth = 6;
            albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            albumDataGridViewTextBoxColumn.Width = 125;
            // 
            // songBindingSource1
            // 
            songBindingSource1.DataMember = "Song";
            songBindingSource1.DataSource = albumBindingSource;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(AlbumsGridView);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)AlbumsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridView AlbumsGridView;
        private BindingSource albumBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource songBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private BindingSource songBindingSource1;
    }
}