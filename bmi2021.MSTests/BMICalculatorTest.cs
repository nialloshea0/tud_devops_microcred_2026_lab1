using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace bmi2021.MSTests;

[TestClass]
public sealed class BMICalculator
{
    [TestMethod]
    [DataRow(8, 2, 6, 1, BMICategory.Underweight)]
    [DataRow(8, 2, 5, 1, BMICategory.Normal)]
    [DataRow(14, 5, 6, 1, BMICategory.Overweight)]
    [DataRow(14, 5, 5, 1, BMICategory.Obese)]
    public void verifyBmiCalculatesNormalCategory(int stones, int pounds, int feet, int inches, BMICategory expectedCategory)
    {
        var bmiModel = new BMI
            {
                WeightStones = stones,
                WeightPounds = pounds,
                HeightFeet = feet,
                HeightInches = inches
            };

        Assert.AreEqual(expectedCategory, bmiModel.BMICategory);    
    }
}
