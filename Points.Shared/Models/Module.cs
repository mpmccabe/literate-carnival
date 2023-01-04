using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Ardalis.SmartEnum;
using Ardalis.SmartEnum.SystemTextJson;

namespace Points.Shared.Models
{

    public class SignalType : SmartEnum<SignalType>
    {
        public static readonly SignalType Voltage = new SignalType(nameof(Voltage), "V", 1);
        public static readonly SignalType Current = new SignalType(nameof(Current), "mA", 2);
        public static readonly SignalType None = new SignalType(nameof(None), String.Empty, 3);
        public string Units { get; }

        protected SignalType(string name, string displayUnits, int value) : base(name, value) { Units = displayUnits; }

    }

    public class ModuleType : SmartEnum<ModuleType>
    {
        public static readonly ModuleType Analog = new ModuleType(nameof(Analog), 1);
        public static readonly ModuleType Digital = new ModuleType(nameof(Digital), 2);

        protected ModuleType(string name, int value) : base(name, value)
        {
        }
    }

    public enum Direction
    {
        In,
        Out,
        InOut,
        None
    }

    public enum TransferType
    {
        Degrees,
        Bucket,
        RPM
    }


    public class Signal
    {
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public SignalType Type { get; set; }
        public TransferType Transfer { get; set; }
    }


    public class Module : Entity
    {
        public string Name { get; set; }
        public double MinCnts { get; set; }
        public double MaxCnts { get; set; }
        [JsonConverter(typeof(SmartEnumValueConverter<ModuleType, int>))]
        public ModuleType Type { get; set; }
        [JsonConverter(typeof(SmartEnumValueConverter<SignalType, int>))]
        public SignalType Signal { get; set; }

        public string Units => "v";
        public int Channels { get; set; }
    }
}
