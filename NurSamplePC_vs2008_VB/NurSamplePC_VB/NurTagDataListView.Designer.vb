Partial Class NurTagDataListView
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.tagListView = New System.Windows.Forms.ListView()
		Me.epcHeader = New System.Windows.Forms.ColumnHeader()
		Me.dataHeader = New System.Windows.Forms.ColumnHeader()
		Me.rssiHeader = New System.Windows.Forms.ColumnHeader()
		Me.SuspendLayout()
		' 
		' tagListView
		' 
		Me.tagListView.Columns.Add(Me.rssiHeader)
		Me.tagListView.Columns.Add(Me.epcHeader)
		Me.tagListView.Columns.Add(Me.dataHeader)
		Me.tagListView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tagListView.FullRowSelect = True
		Me.tagListView.Location = New System.Drawing.Point(0, 0)
		Me.tagListView.Name = "tagListView"
		Me.tagListView.Size = New System.Drawing.Size(378, 261)
		Me.tagListView.TabIndex = 22
		Me.tagListView.View = System.Windows.Forms.View.Details
		' 
		' epcHeader
		' 
		Me.epcHeader.Text = "EPC or DATA"
		Me.epcHeader.Width = 140
		' 
		' dataHeader
		' 
		Me.dataHeader.Text = "DATA"
		Me.dataHeader.Width = 150
		' 
		' rssiHeader
		' 
		Me.rssiHeader.Text = "rssi"
		Me.rssiHeader.Width = 25
		' 
		' NurTagDataListView
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.Controls.Add(Me.tagListView)
		Me.Name = "NurTagDataListView"
		Me.Size = New System.Drawing.Size(378, 261)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Public tagListView As System.Windows.Forms.ListView
	Private epcHeader As System.Windows.Forms.ColumnHeader
	Private dataHeader As System.Windows.Forms.ColumnHeader
	Private rssiHeader As System.Windows.Forms.ColumnHeader
End Class
