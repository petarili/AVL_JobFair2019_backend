using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
    public static class DataSource
    {
        private static IList<Measurement> _measurements { get; set; }

        private static IList<UnitUnderTest> _unitsUnderTest { get; set; }

        public static IList<Measurement> GetMeasurements()
        {
            if (_measurements != null)
            {
                return _measurements;
            }

            _measurements = new List<Measurement>();

            UnitUnderTest BMW = new UnitUnderTest { ID = 2, Name = "BMW M2" };
            UnitUnderTest AUDI = new UnitUnderTest { ID = 1, Name = "Audi Q8" };

            ChannelType CO2_EMISSION = new ChannelType { ID = 1, Name = "CO2 Emission" };

            // measurement #1
            _measurements.Add(new Measurement
            {
                ID = 1,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 0.5,
                Value = 10
            });


            // measurement #2
            _measurements.Add(
            new Measurement
            {
                ID = 2,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 1,
                Value = 25
            });

            // measurement #3
            _measurements.Add(
            new Measurement
            {
                ID = 3,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 1.3,
                Value = 805.3
            });

            // measurement #4
            _measurements.Add(
            new Measurement
            {
                ID = 4,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 5.9,
                Value = 805.3
            });

            // measurement #5
            _measurements.Add(
            new Measurement
            {
                ID = 5,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 6.4,
                Value = 305.3
            });

            // measurement #6
            _measurements.Add(
            new Measurement
            {
                ID = 6,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 11.7,
                Value = 430.0
            });

            // measurement #7
            _measurements.Add(
            new Measurement
            {
                ID = 7,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 17.5,
                Value = 500
            });

            // measurement #8
            _measurements.Add(
            new Measurement
            {
                ID = 8,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 21.3,
                Value = 752
            });

            // measurement #9
            _measurements.Add(
            new Measurement
            {
                ID = 9,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 23.5,
                Value = 680
            });

            // measurement #10
            _measurements.Add(
            new Measurement
            {
                ID = 10,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 43.5,
                Value = 505
            });

            // measurement #11
            _measurements.Add(
            new Measurement
            {
                ID = 11,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 49.5,
                Value = 480
            });

            // measurement #12
            _measurements.Add(
            new Measurement
            {
                ID = 12,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 54,
                Value = 400
            });

            // measurement #13
            _measurements.Add(
            new Measurement
            {
                ID = 13,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 58.1,
                Value = 345
            });

            // measurement #14
            _measurements.Add(
            new Measurement
            {
                ID = 14,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 67,
                Value = 320
            });

            // measurement #15
            _measurements.Add(
            new Measurement
            {
                ID = 15,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 79,
                Value = 445
            });

            // measurement #16
            _measurements.Add(
            new Measurement
            {
                ID = 16,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 84.2,
                Value = 490
            });

            // measurement #17
            _measurements.Add(
            new Measurement
            {
                ID = 17,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 90.4,
                Value = 530
            });

            // measurement #18
            _measurements.Add(
            new Measurement
            {
                ID = 18,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 99.5,
                Value = 550
            });

            // measurement #19
            _measurements.Add(
            new Measurement
            {
                ID = 19,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 103.5,
                Value = 590
            });

            // measurement #20
            _measurements.Add(
            new Measurement
            {
                ID = 20,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 107.1,
                Value = 640
            });

            // measurement #21
            _measurements.Add(
            new Measurement
            {
                ID = 21,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 108.5,
                Value = 600
            });

            // measurement #22
            _measurements.Add(
            new Measurement
            {
                ID = 22,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 110.5,
                Value = 320
            });

            // measurement #23
            _measurements.Add(
            new Measurement
            {
                ID = 23,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 118.5,
                Value = 290
            });

            // measurement #24
            _measurements.Add(
            new Measurement
            {
                ID = 24,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 124,
                Value = 255
            });

            // measurement #25
            _measurements.Add(
            new Measurement
            {
                ID = 25,
                UUT = AUDI.Name,
                CT = CO2_EMISSION.Name,
                Time = 132.5,
                Value = 300
            });


            // measurement #26
            _measurements.Add(new Measurement
            {
                ID = 26,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 0.5,
                Value = 20
            });


            // measurement #27
            _measurements.Add(
            new Measurement
            {
                ID = 27,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 1,
                Value = 35
            });

            // measurement #28
            _measurements.Add(
            new Measurement
            {
                ID = 28,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 1.3,
                Value = 600.5
            });

            // measurement #29
            _measurements.Add(
            new Measurement
            {
                ID = 29,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 5.9,
                Value = 505.3
            });

            // measurement #30
            _measurements.Add(
            new Measurement
            {
                ID = 30,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 6.4,
                Value = 405
            });

            // measurement #31
            _measurements.Add(
            new Measurement
            {
                ID = 31,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 11.7,
                Value = 480
            });

            // measurement #32
            _measurements.Add(
            new Measurement
            {
                ID = 32,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 17.5,
                Value = 590
            });

            // measurement #33
            _measurements.Add(
            new Measurement
            {
                ID = 33,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 21.3,
                Value = 651.5
            });

            // measurement #34
            _measurements.Add(
            new Measurement
            {
                ID = 34,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 23.5,
                Value = 685
            });

            // measurement #35
            _measurements.Add(
            new Measurement
            {
                ID = 35,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 43.5,
                Value = 480
            });

            // measurement #36
            _measurements.Add(
            new Measurement
            {
                ID = 36,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 49.5,
                Value = 470
            });

            // measurement #37
            _measurements.Add(
            new Measurement
            {
                ID = 37,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 54,
                Value = 380
            });

            // measurement #38
            _measurements.Add(
            new Measurement
            {
                ID = 38,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 58.1,
                Value = 350
            });

            // measurement #39
            _measurements.Add(
            new Measurement
            {
                ID = 39,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 67,
                Value = 352
            });

            // measurement #40
            _measurements.Add(
            new Measurement
            {
                ID = 40,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 79,
                Value = 473.5
            });

            // measurement #41
            _measurements.Add(
            new Measurement
            {
                ID = 41,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 84.2,
                Value = 410
            });

            // measurement #42
            _measurements.Add(
            new Measurement
            {
                ID = 42,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 90.4,
                Value = 550.3
            });

            // measurement #43
            _measurements.Add(
            new Measurement
            {
                ID = 43,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 99.5,
                Value = 500
            });

            // measurement #44
            _measurements.Add(
            new Measurement
            {
                ID = 44,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 103.5,
                Value = 585
            });

            // measurement #45
            _measurements.Add(
            new Measurement
            {
                ID = 45,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 107.1,
                Value = 630
            });

            // measurement #46
            _measurements.Add(
            new Measurement
            {
                ID = 46,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 108.5,
                Value = 573
            });

            // measurement #47
            _measurements.Add(
            new Measurement
            {
                ID = 47,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 110.5,
                Value = 355
            });

            // measurement #48
            _measurements.Add(
            new Measurement
            {
                ID = 48,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 118.5,
                Value = 285
            });

            // measurement #49
            _measurements.Add(
            new Measurement
            {
                ID = 49,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 124,
                Value = 257
            });

            // measurement #50
            _measurements.Add(
            new Measurement
            {
                ID = 50,
                UUT = BMW.Name,
                CT = CO2_EMISSION.Name,
                Time = 132.5,
                Value = 300
            });

            return _measurements;
        }

        public static IList<UnitUnderTest> GetUnitsUnderTest()
        {
            if (_unitsUnderTest != null)
            {
                return _unitsUnderTest;
            }

            _unitsUnderTest = new List<UnitUnderTest>();


            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 3,
                Name = "Renault Clio"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 4,
                Name = "Opel Insignia"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 5,
                Name = "Toyota Corola"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 6,
                Name = "Audi R8"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 7,
                Name = "Audi A6"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 8,
                Name = "Renault Talisman"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 9,
                Name = "Tesla X"
            });

            _unitsUnderTest.Add(new UnitUnderTest
            {
                ID = 10,
                Name = "Mazda 6"
            });

            return _unitsUnderTest; 
        }

    }
}
