namespace Hotel_Reservations_UI
{
    partial class CreateFilesForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateRoomInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadHotel = new System.Windows.Forms.Button();
            this.btnCreateHotelList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateHotel,
            this.mnuCreateRoomInventory,
            this.mnuDispHotels,
            this.mnuDispInventory});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuCreateHotel
            // 
            this.mnuCreateHotel.Name = "mnuCreateHotel";
            this.mnuCreateHotel.Size = new System.Drawing.Size(234, 22);
            this.mnuCreateHotel.Text = "Create hotel xml file";
            this.mnuCreateHotel.Click += new System.EventHandler(this.mnuCreateHotel_Click);
            // 
            // mnuCreateRoomInventory
            // 
            this.mnuCreateRoomInventory.Name = "mnuCreateRoomInventory";
            this.mnuCreateRoomInventory.Size = new System.Drawing.Size(234, 22);
            this.mnuCreateRoomInventory.Text = "Create room inventory xml file";
            this.mnuCreateRoomInventory.Click += new System.EventHandler(this.mnuCreateRoomInventory_Click);
            // 
            // mnuDispHotels
            // 
            this.mnuDispHotels.Name = "mnuDispHotels";
            this.mnuDispHotels.Size = new System.Drawing.Size(234, 22);
            this.mnuDispHotels.Text = "Display hotel xml file";
            this.mnuDispHotels.Click += new System.EventHandler(this.mnuDispHotels_Click);
            // 
            // mnuDispInventory
            // 
            this.mnuDispInventory.Name = "mnuDispInventory";
            this.mnuDispInventory.Size = new System.Drawing.Size(234, 22);
            this.mnuDispInventory.Text = "Display inventory xml file";
            this.mnuDispInventory.Click += new System.EventHandler(this.mnuDispInventory_Click);
            // 
            // btnLoadHotel
            // 
            this.btnLoadHotel.Location = new System.Drawing.Point(102, 64);
            this.btnLoadHotel.Name = "btnLoadHotel";
            this.btnLoadHotel.Size = new System.Drawing.Size(467, 44);
            this.btnLoadHotel.TabIndex = 6;
            this.btnLoadHotel.Text = "Load Hotel File (click this before clicking any other buttons)";
            this.btnLoadHotel.UseVisualStyleBackColor = true;
            this.btnLoadHotel.Click += new System.EventHandler(this.btnLoadHotel_Click);
            // 
            // btnCreateHotelList
            // 
            this.btnCreateHotelList.Location = new System.Drawing.Point(102, 136);
            this.btnCreateHotelList.Name = "btnCreateHotelList";
            this.btnCreateHotelList.Size = new System.Drawing.Size(467, 44);
            this.btnCreateHotelList.TabIndex = 7;
            this.btnCreateHotelList.Text = "Create a list of all hotels, and display them in a browser window";
            this.btnCreateHotelList.UseVisualStyleBackColor = true;
            this.btnCreateHotelList.Click += new System.EventHandler(this.btnCreateHotelList_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 286);
            this.Controls.Add(this.btnCreateHotelList);
            this.Controls.Add(this.btnLoadHotel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateHotel;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateRoomInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuDispHotels;
        private System.Windows.Forms.ToolStripMenuItem mnuDispInventory;
        private System.Windows.Forms.Button btnLoadHotel;
        private System.Windows.Forms.Button btnCreateHotelList;
    }
}

