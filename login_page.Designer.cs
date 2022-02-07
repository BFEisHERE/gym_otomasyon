
namespace sgates_software
{
    partial class login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_page));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.kullanıcıadı_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.giris_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.kapat_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanıcıadı_tb
            // 
            this.kullanıcıadı_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.kullanıcıadı_tb, 2);
            this.kullanıcıadı_tb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kullanıcıadı_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıadı_tb.Location = new System.Drawing.Point(235, 222);
            this.kullanıcıadı_tb.Name = "kullanıcıadı_tb";
            this.kullanıcıadı_tb.Size = new System.Drawing.Size(226, 15);
            this.kullanıcıadı_tb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sifre_tb
            // 
            this.sifre_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.sifre_tb, 2);
            this.sifre_tb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sifre_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_tb.Location = new System.Drawing.Point(235, 282);
            this.sifre_tb.Name = "sifre_tb";
            this.sifre_tb.PasswordChar = '•';
            this.sifre_tb.Size = new System.Drawing.Size(226, 15);
            this.sifre_tb.TabIndex = 7;
            this.sifre_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sifre_tb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.sifre_tb, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kullanıcıadı_tb, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.giris_bt, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.kapat_bt, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // giris_bt
            // 
            this.giris_bt.AllowAnimations = true;
            this.giris_bt.AllowMouseEffects = true;
            this.giris_bt.AllowToggling = true;
            this.giris_bt.AnimationSpeed = 200;
            this.giris_bt.AutoGenerateColors = false;
            this.giris_bt.AutoRoundBorders = false;
            this.giris_bt.AutoSizeLeftIcon = true;
            this.giris_bt.AutoSizeRightIcon = true;
            this.giris_bt.BackColor = System.Drawing.Color.Transparent;
            this.giris_bt.BackColor1 = System.Drawing.Color.Transparent;
            this.giris_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris_bt.BackgroundImage")));
            this.giris_bt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.giris_bt.ButtonText = "    Giriş";
            this.giris_bt.ButtonTextMarginLeft = 0;
            this.giris_bt.ColorContrastOnClick = 45;
            this.giris_bt.ColorContrastOnHover = 45;
            this.giris_bt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.giris_bt.CustomizableEdges = borderEdges1;
            this.giris_bt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.giris_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.giris_bt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.giris_bt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.giris_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.giris_bt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.giris_bt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_bt.ForeColor = System.Drawing.Color.GreenYellow;
            this.giris_bt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.giris_bt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.giris_bt.IconMarginLeft = 11;
            this.giris_bt.IconPadding = 10;
            this.giris_bt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.giris_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.giris_bt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.giris_bt.IconSize = 25;
            this.giris_bt.IdleBorderColor = System.Drawing.Color.Transparent;
            this.giris_bt.IdleBorderRadius = 1;
            this.giris_bt.IdleBorderThickness = 1;
            this.giris_bt.IdleFillColor = System.Drawing.Color.Transparent;
            this.giris_bt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("giris_bt.IdleIconLeftImage")));
            this.giris_bt.IdleIconRightImage = null;
            this.giris_bt.IndicateFocus = true;
            this.giris_bt.Location = new System.Drawing.Point(235, 320);
            this.giris_bt.Name = "giris_bt";
            this.giris_bt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.giris_bt.OnDisabledState.BorderRadius = 1;
            this.giris_bt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.giris_bt.OnDisabledState.BorderThickness = 1;
            this.giris_bt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.giris_bt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.giris_bt.OnDisabledState.IconLeftImage = null;
            this.giris_bt.OnDisabledState.IconRightImage = null;
            this.giris_bt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.giris_bt.onHoverState.BorderRadius = 1;
            this.giris_bt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.giris_bt.onHoverState.BorderThickness = 1;
            this.giris_bt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.giris_bt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.giris_bt.onHoverState.IconLeftImage = null;
            this.giris_bt.onHoverState.IconRightImage = null;
            this.giris_bt.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.giris_bt.OnIdleState.BorderRadius = 1;
            this.giris_bt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.giris_bt.OnIdleState.BorderThickness = 1;
            this.giris_bt.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.giris_bt.OnIdleState.ForeColor = System.Drawing.Color.GreenYellow;
            this.giris_bt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("giris_bt.OnIdleState.IconLeftImage")));
            this.giris_bt.OnIdleState.IconRightImage = null;
            this.giris_bt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.giris_bt.OnPressedState.BorderRadius = 1;
            this.giris_bt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.giris_bt.OnPressedState.BorderThickness = 1;
            this.giris_bt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.giris_bt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.giris_bt.OnPressedState.IconLeftImage = null;
            this.giris_bt.OnPressedState.IconRightImage = null;
            this.giris_bt.Size = new System.Drawing.Size(110, 38);
            this.giris_bt.TabIndex = 9;
            this.giris_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.giris_bt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.giris_bt.TextMarginLeft = 0;
            this.giris_bt.TextPadding = new System.Windows.Forms.Padding(0);
            this.giris_bt.UseDefaultRadiusAndThickness = true;
            this.giris_bt.Click += new System.EventHandler(this.giris_bt_Click);
            // 
            // kapat_bt
            // 
            this.kapat_bt.AllowAnimations = true;
            this.kapat_bt.AllowMouseEffects = true;
            this.kapat_bt.AllowToggling = false;
            this.kapat_bt.AnimationSpeed = 200;
            this.kapat_bt.AutoGenerateColors = false;
            this.kapat_bt.AutoRoundBorders = false;
            this.kapat_bt.AutoSizeLeftIcon = true;
            this.kapat_bt.AutoSizeRightIcon = true;
            this.kapat_bt.BackColor = System.Drawing.Color.Transparent;
            this.kapat_bt.BackColor1 = System.Drawing.Color.Transparent;
            this.kapat_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kapat_bt.BackgroundImage")));
            this.kapat_bt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.kapat_bt.ButtonText = "Kapat";
            this.kapat_bt.ButtonTextMarginLeft = 0;
            this.kapat_bt.ColorContrastOnClick = 45;
            this.kapat_bt.ColorContrastOnHover = 45;
            this.kapat_bt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.kapat_bt.CustomizableEdges = borderEdges2;
            this.kapat_bt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kapat_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.kapat_bt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kapat_bt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.kapat_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kapat_bt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.kapat_bt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat_bt.ForeColor = System.Drawing.Color.White;
            this.kapat_bt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kapat_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.kapat_bt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.kapat_bt.IconMarginLeft = 11;
            this.kapat_bt.IconPadding = 10;
            this.kapat_bt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kapat_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.kapat_bt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.kapat_bt.IconSize = 25;
            this.kapat_bt.IdleBorderColor = System.Drawing.Color.Transparent;
            this.kapat_bt.IdleBorderRadius = 1;
            this.kapat_bt.IdleBorderThickness = 1;
            this.kapat_bt.IdleFillColor = System.Drawing.Color.Transparent;
            this.kapat_bt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("kapat_bt.IdleIconLeftImage")));
            this.kapat_bt.IdleIconRightImage = null;
            this.kapat_bt.IndicateFocus = false;
            this.kapat_bt.Location = new System.Drawing.Point(467, 319);
            this.kapat_bt.Name = "kapat_bt";
            this.kapat_bt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.kapat_bt.OnDisabledState.BorderRadius = 1;
            this.kapat_bt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.kapat_bt.OnDisabledState.BorderThickness = 1;
            this.kapat_bt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kapat_bt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.kapat_bt.OnDisabledState.IconLeftImage = null;
            this.kapat_bt.OnDisabledState.IconRightImage = null;
            this.kapat_bt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.kapat_bt.onHoverState.BorderRadius = 1;
            this.kapat_bt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.kapat_bt.onHoverState.BorderThickness = 1;
            this.kapat_bt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.kapat_bt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.kapat_bt.onHoverState.IconLeftImage = null;
            this.kapat_bt.onHoverState.IconRightImage = null;
            this.kapat_bt.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.kapat_bt.OnIdleState.BorderRadius = 1;
            this.kapat_bt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.kapat_bt.OnIdleState.BorderThickness = 1;
            this.kapat_bt.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.kapat_bt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.kapat_bt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("kapat_bt.OnIdleState.IconLeftImage")));
            this.kapat_bt.OnIdleState.IconRightImage = null;
            this.kapat_bt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.kapat_bt.OnPressedState.BorderRadius = 1;
            this.kapat_bt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.kapat_bt.OnPressedState.BorderThickness = 1;
            this.kapat_bt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.kapat_bt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.kapat_bt.OnPressedState.IconLeftImage = null;
            this.kapat_bt.OnPressedState.IconRightImage = null;
            this.kapat_bt.Size = new System.Drawing.Size(114, 39);
            this.kapat_bt.TabIndex = 10;
            this.kapat_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kapat_bt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.kapat_bt.TextMarginLeft = 0;
            this.kapat_bt.TextPadding = new System.Windows.Forms.Padding(0);
            this.kapat_bt.UseDefaultRadiusAndThickness = true;
            this.kapat_bt.Click += new System.EventHandler(this.kapat_bt_Click);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_page";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kullanıcıadı_tb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre_tb;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 giris_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 kapat_bt;
    }
}