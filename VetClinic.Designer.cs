namespace VetClinic
{
    partial class VetClinic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.imageListPets = new System.Windows.Forms.ImageList(this.components);
            this.addPetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(307, 49);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(458, 119);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Vet Clinic";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewPets
            // 
            this.listViewPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPets.GroupImageList = this.imageListPets;
            this.listViewPets.LargeImageList = this.imageListPets;
            this.listViewPets.Location = new System.Drawing.Point(150, 254);
            this.listViewPets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(743, 298);
            this.listViewPets.SmallImageList = this.imageListPets;
            this.listViewPets.TabIndex = 1;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.SelectedIndexChanged += new System.EventHandler(this.listViewPets_SelectedIndexChanged);
            // 
            // imageListPets
            // 
            this.imageListPets.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPets.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPets.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // addPetButton
            // 
            this.addPetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addPetButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPetButton.ForeColor = System.Drawing.Color.White;
            this.addPetButton.Location = new System.Drawing.Point(150, 562);
            this.addPetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPetButton.Name = "addPetButton";
            this.addPetButton.Size = new System.Drawing.Size(743, 78);
            this.addPetButton.TabIndex = 2;
            this.addPetButton.Text = "Add Pet +";
            this.addPetButton.UseMnemonic = false;
            this.addPetButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pets:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(861, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 174);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1440, 948);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPetButton);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VetClinic";
            this.Text = "Vet Clinic";
            this.Load += new System.EventHandler(this.VetClinic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ListView listViewPets;
        private Button addPetButton;
        private ImageList imageListPets;
        private Label label1;
        private Label label2;
    }
}