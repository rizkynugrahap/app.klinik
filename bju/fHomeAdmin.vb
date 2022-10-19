Public Class fHomeAdmin
	Private Sub fHomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub pDashboardDokter_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardDokter.Paint

	End Sub

	Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbObat.CellContentClick

	End Sub

	Private Sub bHome_Click(sender As Object, e As EventArgs) Handles bHome.Click
		pHome.Visible = True
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(2, 144, 188)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDashboardProfit_Click(sender As Object, e As EventArgs) Handles bDashboardProfit.Click
		pHome.Visible = False
		pDashboardProfit.Visible = True
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(2, 144, 188)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDashboardDokter_Click(sender As Object, e As EventArgs) Handles bDashboardDokter.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = True
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(2, 144, 188)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDatabaseSdm_Click(sender As Object, e As EventArgs) Handles bDatabaseSdm.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = True
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(2, 144, 188)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDatabasePoli_Click(sender As Object, e As EventArgs) Handles bDatabasePoli.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = True
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(2, 144, 188)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDatabasePasien_Click(sender As Object, e As EventArgs) Handles bDatabasePasien.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = True
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(2, 144, 188)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDatabaseLab_Click(sender As Object, e As EventArgs) Handles bDatabaseLab.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = True
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(2, 144, 188)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDatabaseObat_Click(sender As Object, e As EventArgs) Handles bDatabaseObat.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = True
		pDaftarKunjungan.Visible = False
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(2, 144, 188)
		bDaftarKunjungan.BackColor = Color.FromArgb(255, 255, 255)
	End Sub

	Private Sub bDaftarKunjungan_Click(sender As Object, e As EventArgs) Handles bDaftarKunjungan.Click
		pHome.Visible = False
		pDashboardProfit.Visible = False
		pDashboardDokter.Visible = False
		pDatabaseSdm.Visible = False
		pDatabasePoli.Visible = False
		pDatabasePasien.Visible = False
		pDatabaseLab.Visible = False
		pDatabaseObat.Visible = False
		pDaftarKunjungan.Visible = True
		bHome.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardProfit.BackColor = Color.FromArgb(255, 255, 255)
		bDashboardDokter.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseSdm.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePoli.BackColor = Color.FromArgb(255, 255, 255)
		bDatabasePasien.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseLab.BackColor = Color.FromArgb(255, 255, 255)
		bDatabaseObat.BackColor = Color.FromArgb(255, 255, 255)
		bDaftarKunjungan.BackColor = Color.FromArgb(2, 144, 188)
	End Sub

	Private Sub bTambahSdm_Click(sender As Object, e As EventArgs) Handles bTambahSdm.Click
		fTambahSdm.Show()
	End Sub
End Class