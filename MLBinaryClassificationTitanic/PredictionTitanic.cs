using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBinaryClassificationTitanic
{
   public class PredictionTitanic
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction;

        public float Score;
    }
}
