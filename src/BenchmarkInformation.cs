using System;

namespace WarehouseManager {

	public class BenchmarkInformationValidationException: Exception {
		public BenchmarkInformationValidationException(string message): base(message) { }
	}

	public class BenchmarkInformation {
		private string _source = string.Empty;
		private int _score;
		private int _maxScore;

		public string Source {
			get => _source;
			set {
				if (string.IsNullOrWhiteSpace(value)) throw new BenchmarkInformationValidationException("\"Source\" cannot be empty.");
				_source = value.Trim();
			}
		}

		public int Score {
			get => _score;
			set {
				if (value < 0) throw new BenchmarkInformationValidationException("\"Score\" cannot be negative.");
				_score = value;
			}
		}

		public int MaxScore {
			get => _maxScore;
			set {
				if (value <= 0) throw new BenchmarkInformationValidationException("\"Maximum Score\" cannot be less than 1.");
				_maxScore = value;
			}
		}

		public BenchmarkInformation(int score, int maxScore, string source) {
			Score = score;
			MaxScore = maxScore;
			Source = source;
		}

		public override string ToString() => $"{Source}: {Score} out of {MaxScore}";
	}
}