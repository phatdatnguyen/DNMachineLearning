﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DNMachineLearning.Clustering
{
    public partial class KMedoidsLearningControl : UserControl
    {
        // Constructor
        public KMedoidsLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            learningParameters.Add("k", KNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            KNumericUpDown.Value = Convert.ToDecimal(learningParameters["k"]);
        }
    }
}
