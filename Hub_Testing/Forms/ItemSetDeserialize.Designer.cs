
namespace Hub_Testing
{
	partial class ItemSetDeserialize
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSetDeserialize));
			this.listBox_maps = new System.Windows.Forms.ListBox();
			this.listBox_champs = new System.Windows.Forms.ListBox();
			this.listBox_items = new System.Windows.Forms.ListBox();
			this.label_maps = new System.Windows.Forms.Label();
			this.label_champs = new System.Windows.Forms.Label();
			this.label_items = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label_name = new System.Windows.Forms.Label();
			this.groupBox_deserialized = new System.Windows.Forms.GroupBox();
			this.textBox_path = new System.Windows.Forms.TextBox();
			this.label_path = new System.Windows.Forms.Label();
			this.button_locate = new System.Windows.Forms.Button();
			this.groupBox_deserialized.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox_maps
			// 
			this.listBox_maps.Enabled = false;
			this.listBox_maps.FormattingEnabled = true;
			this.listBox_maps.Location = new System.Drawing.Point(15, 83);
			this.listBox_maps.Name = "listBox_maps";
			this.listBox_maps.Size = new System.Drawing.Size(120, 199);
			this.listBox_maps.TabIndex = 0;
			// 
			// listBox_champs
			// 
			this.listBox_champs.Enabled = false;
			this.listBox_champs.FormattingEnabled = true;
			this.listBox_champs.Location = new System.Drawing.Point(141, 83);
			this.listBox_champs.Name = "listBox_champs";
			this.listBox_champs.Size = new System.Drawing.Size(120, 199);
			this.listBox_champs.TabIndex = 1;
			// 
			// listBox_items
			// 
			this.listBox_items.Enabled = false;
			this.listBox_items.FormattingEnabled = true;
			this.listBox_items.Location = new System.Drawing.Point(267, 83);
			this.listBox_items.Name = "listBox_items";
			this.listBox_items.Size = new System.Drawing.Size(120, 199);
			this.listBox_items.TabIndex = 2;
			// 
			// label_maps
			// 
			this.label_maps.AutoSize = true;
			this.label_maps.Location = new System.Drawing.Point(12, 67);
			this.label_maps.Name = "label_maps";
			this.label_maps.Size = new System.Drawing.Size(88, 13);
			this.label_maps.TabIndex = 3;
			this.label_maps.Text = "Associated Maps";
			// 
			// label_champs
			// 
			this.label_champs.AutoSize = true;
			this.label_champs.Location = new System.Drawing.Point(138, 67);
			this.label_champs.Name = "label_champs";
			this.label_champs.Size = new System.Drawing.Size(114, 13);
			this.label_champs.TabIndex = 4;
			this.label_champs.Text = "Associated Champions";
			// 
			// label_items
			// 
			this.label_items.AutoSize = true;
			this.label_items.Location = new System.Drawing.Point(264, 67);
			this.label_items.Name = "label_items";
			this.label_items.Size = new System.Drawing.Size(32, 13);
			this.label_items.TabIndex = 5;
			this.label_items.Text = "Items";
			// 
			// textBox_name
			// 
			this.textBox_name.Enabled = false;
			this.textBox_name.Location = new System.Drawing.Point(15, 32);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(372, 20);
			this.textBox_name.TabIndex = 6;
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(12, 16);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(35, 13);
			this.label_name.TabIndex = 7;
			this.label_name.Text = "Name";
			// 
			// groupBox_deserialized
			// 
			this.groupBox_deserialized.Controls.Add(this.label_name);
			this.groupBox_deserialized.Controls.Add(this.textBox_name);
			this.groupBox_deserialized.Controls.Add(this.label_maps);
			this.groupBox_deserialized.Controls.Add(this.listBox_maps);
			this.groupBox_deserialized.Controls.Add(this.label_champs);
			this.groupBox_deserialized.Controls.Add(this.listBox_champs);
			this.groupBox_deserialized.Controls.Add(this.label_items);
			this.groupBox_deserialized.Controls.Add(this.listBox_items);
			this.groupBox_deserialized.Location = new System.Drawing.Point(12, 74);
			this.groupBox_deserialized.Name = "groupBox_deserialized";
			this.groupBox_deserialized.Size = new System.Drawing.Size(398, 298);
			this.groupBox_deserialized.TabIndex = 8;
			this.groupBox_deserialized.TabStop = false;
			this.groupBox_deserialized.Text = "ItemSet Deserialize";
			// 
			// textBox_path
			// 
			this.textBox_path.Location = new System.Drawing.Point(89, 15);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.ReadOnly = true;
			this.textBox_path.Size = new System.Drawing.Size(243, 20);
			this.textBox_path.TabIndex = 9;
			// 
			// label_path
			// 
			this.label_path.AutoSize = true;
			this.label_path.Location = new System.Drawing.Point(12, 18);
			this.label_path.Name = "label_path";
			this.label_path.Size = new System.Drawing.Size(71, 13);
			this.label_path.TabIndex = 10;
			this.label_path.Text = "ItemSet Path:";
			// 
			// button_locate
			// 
			this.button_locate.Location = new System.Drawing.Point(336, 14);
			this.button_locate.Name = "button_locate";
			this.button_locate.Size = new System.Drawing.Size(75, 22);
			this.button_locate.TabIndex = 11;
			this.button_locate.Text = "Locate";
			this.button_locate.UseVisualStyleBackColor = true;
			this.button_locate.Click += new System.EventHandler(this.button_locate_Click);
			// 
			// ItemSetDeserialize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 384);
			this.Controls.Add(this.label_path);
			this.Controls.Add(this.textBox_path);
			this.Controls.Add(this.button_locate);
			this.Controls.Add(this.groupBox_deserialized);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemSetDeserialize";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ItemSet Deserialize";
			this.groupBox_deserialized.ResumeLayout(false);
			this.groupBox_deserialized.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox_maps;
		private System.Windows.Forms.ListBox listBox_champs;
		private System.Windows.Forms.ListBox listBox_items;
		private System.Windows.Forms.Label label_maps;
		private System.Windows.Forms.Label label_champs;
		private System.Windows.Forms.Label label_items;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.GroupBox groupBox_deserialized;
		private System.Windows.Forms.TextBox textBox_path;
		private System.Windows.Forms.Label label_path;
		private System.Windows.Forms.Button button_locate;
	}
}

