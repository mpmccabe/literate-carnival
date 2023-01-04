using Points.Shared.Models;
using System.Text.Json;
using Ardalis.SmartEnum.SystemTextJson;
namespace Points.Shared.Tests
{
    [TestClass]
    public class UnitTest1
    {
    [TestMethod]
    public void SerializedCorrectly()
        {
            var testModule = new Module
            {
                Id = 1,
                Name = "750-550",

                MinCnts = 0,

                MaxCnts = 32764,

                Type = ModuleType.Analog,

                Signal = SignalType.Voltage,

                Channels = 2
            };

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            var json = JsonSerializer.Serialize(testModule, options);
            var crap = JsonSerializer.Deserialize<Module>(json, options);

            Assert.AreEqual(testModule.Name, crap.Name);
            Assert.AreEqual(testModule.Type, crap.Type);
            Assert.AreEqual(testModule.Signal, crap.Signal);
        }
    }
}