using System;
using System.ComponentModel;
using System.Windows.Forms;
using UIControls.StandardControls;
using Types = TagLibrary.Types;
using DevExpress.XtraEditors;

namespace TagEditor.Controls
{
	public class ShortBlockIndex : Field
	{
    private AutoSizeLabel lblName;
    private TextEdit txtValue;
		private IContainer components = null;

    private Types.ShortBlockIndex value;

    public Types.ShortBlockIndex Value
    {
      get { return this.value;}
      set { this.value = value; }
    }

		public ShortBlockIndex()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

    public override void Configure(System.Xml.XmlNode valueNode)
    {
      base.Configure(valueNode);
      this.lblName.Text = Caption;
    }

	  public override void DataBind(Types.IField value)
    {
      if (!(value is Types.ShortBlockIndex))
        throw new Exception("Cannot bind " + value.ToString() + " to ShortBlockIndex control.");

      this.value = (value as Types.ShortBlockIndex);
      // Don't databind for now - just leave it blank.
      //      this.txtValue.DataBindings.Clear();
      //      this.txtValue.DataBindings.Add(new Binding("Text", this.value, "Value"));
    }


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.lblName = new UIControls.StandardControls.AutoSizeLabel();
      this.txtValue = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.AutoSizeHeight = false;
      this.lblName.Location = new System.Drawing.Point(4, 5);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(128, 16);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Short Block Index";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtValue
      // 
      this.txtValue.EditValue = "";
      this.txtValue.Location = new System.Drawing.Point(140, 4);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(144, 20);
      this.txtValue.TabIndex = 1;
      // 
      // ShortInteger
      // 
      this.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.Appearance.Options.UseBackColor = true;
      this.Controls.Add(this.txtValue);
      this.Controls.Add(this.lblName);
      this.Name = "ShortInteger";
      this.Size = new System.Drawing.Size(288, 28);
      ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion
	}
}

