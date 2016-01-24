Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Reporting.WinForms

Namespace AllForms

    <DesignerGenerated()> _
    Partial Class ReportUnpaid
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportUnpaid))
            Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.SuspendLayout()
            '
            'ReportViewer1
            '
            Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                              Or System.Windows.Forms.AnchorStyles.Left) _
                                             Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            ReportDataSource1.Name = "DataSet1"
            ReportDataSource1.Value = Nothing
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "repDay.rdlc"
            Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
            Me.ReportViewer1.Name = "ReportViewer1"
            Me.ReportViewer1.Size = New System.Drawing.Size(693, 200)
            Me.ReportViewer1.TabIndex = 0
            '
            'ReportUnpaid
            '
            Me.ClientSize = New System.Drawing.Size(717, 224)
            Me.Controls.Add(Me.ReportViewer1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ReportUnpaid"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "รายงานยอดค้างจ่าย"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ReportViewer1 As ReportViewer

    End Class
End NameSpace