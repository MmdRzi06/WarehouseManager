
namespace WarehouseManager {
	public partial class FormModifyBenchmarkInfo: Form {

		private readonly long ComponentID;
		private readonly BenchmarkInformation? ComponentBenchmarkInfo;

		public FormModifyBenchmarkInfo(long componentID) {
			InitializeComponent();
			ComponentID = componentID;
			ComponentBenchmarkInfo = Products.GetComponentBenchmarkInfo(componentID);
			if (ComponentBenchmarkInfo is null) {
				btnRemoveInfo.Hide();
				lblInstruction.Hide();
				Text = "Add Benchmark Info";
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (ComponentBenchmarkInfo is not null) {

				string? source = null;
				int? score = null;
				int? maxScore = null;

				bool AllFieldsNull = true;

				if (!string.IsNullOrWhiteSpace(tbxSource.Text)) {
					source = tbxSource.Text;
					AllFieldsNull = false;
				} else {
					source = ComponentBenchmarkInfo.Source;
				}

				if (!string.IsNullOrWhiteSpace(tbxAverageScore.Text)) {
					score = int.Parse(tbxAverageScore.Text);
					AllFieldsNull = false;
				} else {
					score = ComponentBenchmarkInfo.Score;
				}

				if (!string.IsNullOrWhiteSpace(tbxMaximumScore.Text)) {
					maxScore = int.Parse(tbxMaximumScore.Text);
					AllFieldsNull = false;
				} else {
					maxScore = ComponentBenchmarkInfo.MaxScore;
				}

				if (AllFieldsNull) {
					lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
					return;
				}

				try {
					BenchmarkInformation benchmarkInfo = new BenchmarkInformation((int)score, (int)maxScore, source);
					Products.ModifyComputerComponent(ComponentID, benchmarkInfo);
					Close();
				} catch (BenchmarkInformationValidationException ex) {
					lblError.Text = ex.Message;
					return;
				}

			} else {

				if (string.IsNullOrWhiteSpace(tbxSource.Text) ||
					string.IsNullOrWhiteSpace(tbxAverageScore.Text) ||
					string.IsNullOrWhiteSpace(tbxMaximumScore.Text)) {
					lblError.Text = FormSharedErrors.AddFormEmptyFields;
					return;
				}


				string source = tbxSource.Text;
				int score = int.Parse(tbxAverageScore.Text);
				int maxScore = int.Parse(tbxMaximumScore.Text);

				try {
					BenchmarkInformation benchmarkInfo = new BenchmarkInformation(score, maxScore, source);
					Products.ModifyComputerComponent(ComponentID, benchmarkInfo);
					Close();
				} catch (BenchmarkInformationValidationException ex) {
					lblError.Text = ex.Message;
					return;
				}

			}
		}

		private void btnRemoveInfo_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to remove the Benchmark Info of this product?",
				"Benchmark Info Removal",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) {
				Products.ModifyComputerComponent(ComponentID, null);
				Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void StringTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.StringTextBoxes_KeyPress(sender, e);
		}

		private void IntTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.IntTextBoxes_KeyPress(sender, e);
		}
	}
}
