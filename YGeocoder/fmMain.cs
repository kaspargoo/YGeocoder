using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Yandex;

namespace YGeocoder
{
    public partial class fmMain : Form
    {
        public bool StopFlag = false;
        public LangType RespLang;
        GeoPoint centerPoint;

        public fmMain()
        {
            InitializeComponent();
            ApplyGridStype();
            InitLangCB();
        }

        void InitLangCB()
        {
            this.cbLang.DataSource = Enum.GetNames(typeof(LangType));
        }

        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<LangType>(cbLang.SelectedValue.ToString(), out RespLang);
        }

        void ApplyGridStype()
        {
            this.dgData.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            this.dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgData.ColumnHeadersDefaultCellStyle.Font =
               new Font(this.dgData.Font, FontStyle.Bold);

            this.dgData.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            this.dgData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dgData.GridColor = Color.Black;
            this.dgData.RowHeadersVisible = false;
            this.dgData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dgData.AllowUserToResizeRows = false;
            /*
                        this.dgData.Columns[4].DefaultCellStyle.Font =
                            new Font(this.dgData.DefaultCellStyle.Font, FontStyle.Italic);
                        this.dgData.SelectionMode =
                            DataGridViewSelectionMode.FullRowSelect;
                        this.dgData.MultiSelect = true;
            */
        }

        private void btGeo_Click(object sender, EventArgs e)
        {
            tsStatus.Text = "Single geocoding...";
//            tsProgressBar.Value = 10;
            Application.DoEvents();

            GeoObjectCollection results = YandexGeocoder.Geocode(tbAddress.Text, 1, RespLang);
            if (results.Count() > 0)
            {
                // Check for memory leaks!!!
                centerPoint = results.First().Point;
                // Check for memory leaks!!!
                tbCoordinates.Text = centerPoint.ToString();//string.Format("{1} {0}", centerPoint.Long.ToString(CultureInfo.InvariantCulture), centerPoint.Lat.ToString(CultureInfo.InvariantCulture));
                tsStatus.Text = "Ready";
//                tsProgressBar.Value = 0;
            }
            else
            {
                tbCoordinates.Text = "0.00 0.00";
                tsStatus.Text = "Request returned no results";
//                tsProgressBar.Value = 0;
            }
                
/*            foreach (GeoObject result in results)
            {
                Console.WriteLine(result.Point.ToString());
            }
*/
        }

        private void btReverseGeo_Click(object sender, EventArgs e)
        {
            tsStatus.Text = "Single rev. geocoding...";
            Application.DoEvents();

            GeoObjectCollection results = YandexGeocoder.Geocode(tbCoordinates.Text, 1, RespLang);
            if (results.Count() > 0)
            {
                tbAddress.Text = results.First().GeocoderMetaData.Text.ToString();
                tsStatus.Text = "Ready";
            }
            else
            {
                tbAddress.Text = "";
                tsStatus.Text = "Request returned no results";
            }
        }

        private void lbAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YGeocoder v. 0.2. Alexander Kozlov 2015, kaspargoo@gmail.com" + Environment.NewLine + "Based on YandexGeocoder by Michael Verhov" + Environment.NewLine + "http://michael.verhov.com/en/post/yandex_geocoder",
                            "About YGeocoder v. 0.2");
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgData.Rows.Clear();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(dgData.GetClipboardContent());
        }

        private void miCopyAll_Click(object sender, EventArgs e)
        {
            // Add the selection to the clipboard.
            Clipboard.SetDataObject(
                this.dgData.GetClipboardContent());
        }
        
        private void miPaste_Click(object sender, EventArgs e)
        {
            try
            {
                dgData.Rows.Clear();
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iRow = 0; // dgData.CurrentCell.RowIndex;
                int iCol = 0; // dgData.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (string line in lines)
                {
                    if (/*iRow < dgData.RowCount && */line.Length > 0)
                    {
                        dgData.Rows.Add();
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dgData.ColumnCount)
                            {
                                oCell = dgData[iCol + i, iRow];
                                oCell.Value = Convert.ChangeType(sCells[i],
                                                      oCell.ValueType);
//                                   oCell.Style.BackColor = Color.Tomato;
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
                return;
            }

        }

        private void btGeoAll_Click(object sender, EventArgs e)
        {
            bool useCenterPoint = false;
            SearchArea sArea = new SearchArea();
            
            if (dgData.Rows.Count <= 1)
            {
                tsStatus.Text = "Grid is empty. Insert addresses using context menu first.";
                return;
            }

            if (cbCenterPriority.Checked /*&& (tbCoordinates.Text.Length > 0)*/)
            {
                try
                {
                    centerPoint = Yandex.GeoPoint.Parse(tbCoordinates.Text);
                    sArea.LongLat = centerPoint;
                    sArea.Spread = new GeoPoint(0, 0);
                    useCenterPoint = true;
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("The data provided in Coordinates field is not correct." + Environment.NewLine +
                                                                "Press Ok to continue without this option or Cancel to stop.",
                                                                "Center point input", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        useCenterPoint = false;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            try
            {
                btGeoAll.Enabled = false;
                btClear.Enabled = false;
                btStop.Enabled = true;
                StopFlag = false;

                int good = 0, bad = 0;
                int total = dgData.Rows.Count;
                tsStatus.Text = "Batch geocoding...";
                tsProgressBar.Maximum = total;
                DateTime startTime = DateTime.Now;
                foreach (DataGridViewRow row in dgData.Rows)
                {
                    if (StopFlag)
                    {
                        tsStatus.Text += " Interrupted..";
                        break;
                    }
                    tsProgressBar.Value += 1;
                    DateTime endTime = DateTime.Now;
                    TimeSpan duration = endTime.Subtract(startTime);

                    Application.DoEvents();
                    if ((row == null) || (row.Cells[0].Value == null)) { continue; }
                    GeoObjectCollection results;
                    if (!useCenterPoint) results = YandexGeocoder.Geocode(row.Cells[0].Value.ToString(), 1, RespLang);
                    else results = YandexGeocoder.Geocode(row.Cells[0].Value.ToString(), 1, RespLang, sArea);
                    if (results.Count() > 0)
                    {
                        GeoObject goResponse = results.First();
                        row.Cells[1].Value = goResponse.GeocoderMetaData.Text.ToString(); 
                        row.Cells[2].Value = goResponse.Point.Lat.ToString();
                        row.Cells[3].Value = goResponse.Point.Long.ToString();
                        row.Cells[4].Value = ((useCenterPoint) ? String.Format("{0:0.0}", GeoFunctions.GetDistance(goResponse.Point.Lat, goResponse.Point.Long, centerPoint.Lat, centerPoint.Long)) : ""); 
                        row.Cells[5].Value = goResponse.GeocoderMetaData.Kind.ToString();
                        row.Cells[6].Value = goResponse.GeocoderMetaData.Precision.ToString();
                        /*                        row.Cells[6].Value = goResponse.Point.Long.ToString();
                                                row.Cells[7].Value = goResponse.Point.Long.ToString();
                                                row.Cells[8].Value = goResponse.Point.Long.ToString();
                        */
                        row.DefaultCellStyle.BackColor = default(Color);
/*                        if (cbGetReverseAddr.Checked)
                        {
                            GeoObjectCollection revresults = YandexGeocoder.Geocode(goResponse.Point.ToString(), 1, RespLang);
                            if (revresults.Count() > 0) { row.Cells[1].Value = revgoResponse.GeocoderMetaData.Text.ToString(); }
                        }
*/                        good += 1;
                        tsStatus.Text = String.Format("Processed {0} of {1} ({2} - good, {3} - bad). {4:hh\\:mm\\:ss} elapsed ", good + bad, total-1, good, bad, duration);
                    }
                    else
                    {
                        row.Cells[2].Value = "0.00";
                        row.Cells[3].Value = "0.00";
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                        bad += 1;
                        tsStatus.Text = String.Format("Processed {0} of {1} ({2} - good, {3} - bad). {4:hh\\:mm\\:ss} elapsed ", good + bad, total-1, good, bad, duration);
                    }
                }
                tsProgressBar.Value = 0;
            }
            finally
            {
                btGeoAll.Enabled = true;
                btClear.Enabled = true;
                btStop.Enabled = false;
                tsProgressBar.Value = 0;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            StopFlag = true;
        }
    }
}
