﻿using Newtonsoft.Json;
using Tanks.Core.api;
using Xunit;

namespace Tanks.Tests
{
    public class GameSetupSerializationTests
    {
        [Fact]
        public void should_serialize_response_content()
        {
            var gameSetup = JsonConvert.DeserializeObject<GameSetup>(content);

            Assert.NotNull(gameSetup);
        }

        private const string content = @"{
  ""name"" : ""master game #225"",
  ""scene"" : {
    ""landscape"" : {
      ""points"" : [ {
        ""x"" : -500,
        ""y"" : 112.18
      }, {
        ""x"" : -497.49,
        ""y"" : 111.49
      }, {
        ""x"" : -494.99,
        ""y"" : 110.61
      }, {
        ""x"" : -492.48,
        ""y"" : 109.54
      }, {
        ""x"" : -489.97,
        ""y"" : 108.3
      }, {
        ""x"" : -487.47,
        ""y"" : 106.89
      }, {
        ""x"" : -484.96,
        ""y"" : 105.33
      }, {
        ""x"" : -482.46,
        ""y"" : 103.64
      }, {
        ""x"" : -479.95,
        ""y"" : 101.83
      }, {
        ""x"" : -477.44,
        ""y"" : 99.92
      }, {
        ""x"" : -474.94,
        ""y"" : 97.93
      }, {
        ""x"" : -472.43,
        ""y"" : 95.87
      }, {
        ""x"" : -469.92,
        ""y"" : 93.78
      }, {
        ""x"" : -467.42,
        ""y"" : 91.66
      }, {
        ""x"" : -464.91,
        ""y"" : 89.55
      }, {
        ""x"" : -462.41,
        ""y"" : 87.45
      }, {
        ""x"" : -459.9,
        ""y"" : 85.39
      }, {
        ""x"" : -457.39,
        ""y"" : 83.39
      }, {
        ""x"" : -454.89,
        ""y"" : 81.46
      }, {
        ""x"" : -452.38,
        ""y"" : 79.63
      }, {
        ""x"" : -449.87,
        ""y"" : 77.91
      }, {
        ""x"" : -447.37,
        ""y"" : 76.31
      }, {
        ""x"" : -444.86,
        ""y"" : 74.85
      }, {
        ""x"" : -442.36,
        ""y"" : 73.55
      }, {
        ""x"" : -439.85,
        ""y"" : 72.4
      }, {
        ""x"" : -437.34,
        ""y"" : 71.43
      }, {
        ""x"" : -434.84,
        ""y"" : 70.63
      }, {
        ""x"" : -432.33,
        ""y"" : 70.01
      }, {
        ""x"" : -429.82,
        ""y"" : 69.58
      }, {
        ""x"" : -427.32,
        ""y"" : 69.32
      }, {
        ""x"" : -424.81,
        ""y"" : 69.25
      }, {
        ""x"" : -422.31,
        ""y"" : 69.35
      }, {
        ""x"" : -419.8,
        ""y"" : 69.61
      }, {
        ""x"" : -417.29,
        ""y"" : 70.03
      }, {
        ""x"" : -414.79,
        ""y"" : 70.59
      }, {
        ""x"" : -412.28,
        ""y"" : 71.27
      }, {
        ""x"" : -409.77,
        ""y"" : 72.05
      }, {
        ""x"" : -407.27,
        ""y"" : 72.91
      }, {
        ""x"" : -404.76,
        ""y"" : 73.82
      }, {
        ""x"" : -402.26,
        ""y"" : 74.75
      }, {
        ""x"" : -399.75,
        ""y"" : 75.7
      }, {
        ""x"" : -397.24,
        ""y"" : 76.78
      }, {
        ""x"" : -394.74,
        ""y"" : 78.07
      }, {
        ""x"" : -392.23,
        ""y"" : 79.64
      }, {
        ""x"" : -389.72,
        ""y"" : 81.56
      }, {
        ""x"" : -387.22,
        ""y"" : 83.86
      }, {
        ""x"" : -384.71,
        ""y"" : 86.57
      }, {
        ""x"" : -382.21,
        ""y"" : 89.7
      }, {
        ""x"" : -379.7,
        ""y"" : 93.26
      }, {
        ""x"" : -377.19,
        ""y"" : 97.24
      }, {
        ""x"" : -374.69,
        ""y"" : 101.62
      }, {
        ""x"" : -372.18,
        ""y"" : 106.38
      }, {
        ""x"" : -369.67,
        ""y"" : 111.48
      }, {
        ""x"" : -367.17,
        ""y"" : 116.9
      }, {
        ""x"" : -364.66,
        ""y"" : 122.58
      }, {
        ""x"" : -362.16,
        ""y"" : 128.49
      }, {
        ""x"" : -359.65,
        ""y"" : 134.56
      }, {
        ""x"" : -357.14,
        ""y"" : 140.77
      }, {
        ""x"" : -354.64,
        ""y"" : 147.04
      }, {
        ""x"" : -352.13,
        ""y"" : 153.33
      }, {
        ""x"" : -349.62,
        ""y"" : 159.59
      }, {
        ""x"" : -347.12,
        ""y"" : 165.77
      }, {
        ""x"" : -344.61,
        ""y"" : 171.81
      }, {
        ""x"" : -342.11,
        ""y"" : 177.67
      }, {
        ""x"" : -339.6,
        ""y"" : 183.3
      }, {
        ""x"" : -337.09,
        ""y"" : 188.66
      }, {
        ""x"" : -334.59,
        ""y"" : 193.71
      }, {
        ""x"" : -332.08,
        ""y"" : 198.42
      }, {
        ""x"" : -329.57,
        ""y"" : 202.75
      }, {
        ""x"" : -327.07,
        ""y"" : 206.68
      }, {
        ""x"" : -324.56,
        ""y"" : 210.18
      }, {
        ""x"" : -322.06,
        ""y"" : 213.25
      }, {
        ""x"" : -319.55,
        ""y"" : 215.86
      }, {
        ""x"" : -317.04,
        ""y"" : 218
      }, {
        ""x"" : -314.54,
        ""y"" : 219.69
      }, {
        ""x"" : -312.03,
        ""y"" : 220.91
      }, {
        ""x"" : -309.52,
        ""y"" : 221.68
      }, {
        ""x"" : -307.02,
        ""y"" : 222
      }, {
        ""x"" : -304.51,
        ""y"" : 221.9
      }, {
        ""x"" : -302.01,
        ""y"" : 221.39
      }, {
        ""x"" : -299.5,
        ""y"" : 220.51
      }, {
        ""x"" : -296.99,
        ""y"" : 219.27
      }, {
        ""x"" : -294.49,
        ""y"" : 217.72
      }, {
        ""x"" : -291.98,
        ""y"" : 215.88
      }, {
        ""x"" : -289.47,
        ""y"" : 213.8
      }, {
        ""x"" : -286.97,
        ""y"" : 211.52
      }, {
        ""x"" : -284.46,
        ""y"" : 209.08
      }, {
        ""x"" : -281.95,
        ""y"" : 206.52
      }, {
        ""x"" : -279.45,
        ""y"" : 203.89
      }, {
        ""x"" : -276.94,
        ""y"" : 201.23
      }, {
        ""x"" : -274.44,
        ""y"" : 198.54
      }, {
        ""x"" : -271.93,
        ""y"" : 195.78
      }, {
        ""x"" : -269.42,
        ""y"" : 192.87
      }, {
        ""x"" : -266.92,
        ""y"" : 189.78
      }, {
        ""x"" : -264.41,
        ""y"" : 186.48
      }, {
        ""x"" : -261.9,
        ""y"" : 182.95
      }, {
        ""x"" : -259.4,
        ""y"" : 179.19
      }, {
        ""x"" : -256.89,
        ""y"" : 175.21
      }, {
        ""x"" : -254.39,
        ""y"" : 171.02
      }, {
        ""x"" : -251.88,
        ""y"" : 166.64
      }, {
        ""x"" : -249.37,
        ""y"" : 162.09
      }, {
        ""x"" : -246.87,
        ""y"" : 157.42
      }, {
        ""x"" : -244.36,
        ""y"" : 152.66
      }, {
        ""x"" : -241.85,
        ""y"" : 147.84
      }, {
        ""x"" : -239.35,
        ""y"" : 143.01
      }, {
        ""x"" : -236.84,
        ""y"" : 138.21
      }, {
        ""x"" : -234.34,
        ""y"" : 133.48
      }, {
        ""x"" : -231.83,
        ""y"" : 128.86
      }, {
        ""x"" : -229.32,
        ""y"" : 124.4
      }, {
        ""x"" : -226.82,
        ""y"" : 120.13
      }, {
        ""x"" : -224.31,
        ""y"" : 116.09
      }, {
        ""x"" : -221.8,
        ""y"" : 112.31
      }, {
        ""x"" : -219.3,
        ""y"" : 108.82
      }, {
        ""x"" : -216.79,
        ""y"" : 105.65
      }, {
        ""x"" : -214.29,
        ""y"" : 102.83
      }, {
        ""x"" : -211.78,
        ""y"" : 100.36
      }, {
        ""x"" : -209.27,
        ""y"" : 98.26
      }, {
        ""x"" : -206.77,
        ""y"" : 96.54
      }, {
        ""x"" : -204.26,
        ""y"" : 95.2
      }, {
        ""x"" : -201.75,
        ""y"" : 94.25
      }, {
        ""x"" : -199.25,
        ""y"" : 93.68
      }, {
        ""x"" : -196.74,
        ""y"" : 93.48
      }, {
        ""x"" : -194.24,
        ""y"" : 93.64
      }, {
        ""x"" : -191.73,
        ""y"" : 94.14
      }, {
        ""x"" : -189.22,
        ""y"" : 94.95
      }, {
        ""x"" : -186.72,
        ""y"" : 96.06
      }, {
        ""x"" : -184.21,
        ""y"" : 97.44
      }, {
        ""x"" : -181.7,
        ""y"" : 99.05
      }, {
        ""x"" : -179.2,
        ""y"" : 100.87
      }, {
        ""x"" : -176.69,
        ""y"" : 102.87
      }, {
        ""x"" : -174.19,
        ""y"" : 105.02
      }, {
        ""x"" : -171.68,
        ""y"" : 107.27
      }, {
        ""x"" : -169.17,
        ""y"" : 109.61
      }, {
        ""x"" : -166.67,
        ""y"" : 112
      }, {
        ""x"" : -164.16,
        ""y"" : 114.42
      }, {
        ""x"" : -161.65,
        ""y"" : 116.86
      }, {
        ""x"" : -159.15,
        ""y"" : 119.29
      }, {
        ""x"" : -156.64,
        ""y"" : 121.7
      }, {
        ""x"" : -154.14,
        ""y"" : 124.1
      }, {
        ""x"" : -151.63,
        ""y"" : 126.5
      }, {
        ""x"" : -149.12,
        ""y"" : 128.89
      }, {
        ""x"" : -146.62,
        ""y"" : 131.24
      }, {
        ""x"" : -144.11,
        ""y"" : 133.5
      }, {
        ""x"" : -141.6,
        ""y"" : 135.65
      }, {
        ""x"" : -139.1,
        ""y"" : 137.64
      }, {
        ""x"" : -136.59,
        ""y"" : 139.44
      }, {
        ""x"" : -134.09,
        ""y"" : 141.02
      }, {
        ""x"" : -131.58,
        ""y"" : 142.34
      }, {
        ""x"" : -129.07,
        ""y"" : 143.4
      }, {
        ""x"" : -126.57,
        ""y"" : 144.15
      }, {
        ""x"" : -124.06,
        ""y"" : 144.59
      }, {
        ""x"" : -121.55,
        ""y"" : 144.7
      }, {
        ""x"" : -119.05,
        ""y"" : 144.46
      }, {
        ""x"" : -116.54,
        ""y"" : 143.88
      }, {
        ""x"" : -114.04,
        ""y"" : 142.95
      }, {
        ""x"" : -111.53,
        ""y"" : 141.67
      }, {
        ""x"" : -109.02,
        ""y"" : 140.04
      }, {
        ""x"" : -106.52,
        ""y"" : 138.07
      }, {
        ""x"" : -104.01,
        ""y"" : 135.78
      }, {
        ""x"" : -101.5,
        ""y"" : 133.18
      }, {
        ""x"" : -99,
        ""y"" : 130.3
      }, {
        ""x"" : -96.49,
        ""y"" : 127.14
      }, {
        ""x"" : -93.98,
        ""y"" : 123.75
      }, {
        ""x"" : -91.48,
        ""y"" : 120.15
      }, {
        ""x"" : -88.97,
        ""y"" : 116.37
      }, {
        ""x"" : -86.47,
        ""y"" : 112.44
      }, {
        ""x"" : -83.96,
        ""y"" : 108.4
      }, {
        ""x"" : -81.45,
        ""y"" : 104.29
      }, {
        ""x"" : -78.95,
        ""y"" : 100.14
      }, {
        ""x"" : -76.44,
        ""y"" : 96
      }, {
        ""x"" : -73.93,
        ""y"" : 91.9
      }, {
        ""x"" : -71.43,
        ""y"" : 87.88
      }, {
        ""x"" : -68.92,
        ""y"" : 83.99
      }, {
        ""x"" : -66.42,
        ""y"" : 80.25
      }, {
        ""x"" : -63.91,
        ""y"" : 76.71
      }, {
        ""x"" : -61.4,
        ""y"" : 73.39
      }, {
        ""x"" : -58.9,
        ""y"" : 70.33
      }, {
        ""x"" : -56.39,
        ""y"" : 67.56
      }, {
        ""x"" : -53.88,
        ""y"" : 65.1
      }, {
        ""x"" : -51.38,
        ""y"" : 62.97
      }, {
        ""x"" : -48.87,
        ""y"" : 61.18
      }, {
        ""x"" : -46.37,
        ""y"" : 59.74
      }, {
        ""x"" : -43.86,
        ""y"" : 58.65
      }, {
        ""x"" : -41.35,
        ""y"" : 57.89
      }, {
        ""x"" : -38.85,
        ""y"" : 57.46
      }, {
        ""x"" : -36.34,
        ""y"" : 57.33
      }, {
        ""x"" : -33.83,
        ""y"" : 57.46
      }, {
        ""x"" : -31.33,
        ""y"" : 57.79
      }, {
        ""x"" : -28.82,
        ""y"" : 58.28
      }, {
        ""x"" : -26.32,
        ""y"" : 58.85
      }, {
        ""x"" : -23.81,
        ""y"" : 59.46
      }, {
        ""x"" : -21.3,
        ""y"" : 60.14
      }, {
        ""x"" : -18.8,
        ""y"" : 60.96
      }, {
        ""x"" : -16.29,
        ""y"" : 61.95
      }, {
        ""x"" : -13.78,
        ""y"" : 63.14
      }, {
        ""x"" : -11.28,
        ""y"" : 64.56
      }, {
        ""x"" : -8.77,
        ""y"" : 66.21
      }, {
        ""x"" : -6.27,
        ""y"" : 68.11
      }, {
        ""x"" : -3.76,
        ""y"" : 70.25
      }, {
        ""x"" : -1.25,
        ""y"" : 72.62
      }, {
        ""x"" : 1.25,
        ""y"" : 75.21
      }, {
        ""x"" : 3.76,
        ""y"" : 78.01
      }, {
        ""x"" : 6.27,
        ""y"" : 80.99
      }, {
        ""x"" : 8.77,
        ""y"" : 84.13
      }, {
        ""x"" : 11.28,
        ""y"" : 87.41
      }, {
        ""x"" : 13.78,
        ""y"" : 90.79
      }, {
        ""x"" : 16.29,
        ""y"" : 94.25
      }, {
        ""x"" : 18.8,
        ""y"" : 97.75
      }, {
        ""x"" : 21.3,
        ""y"" : 101.27
      }, {
        ""x"" : 23.81,
        ""y"" : 104.78
      }, {
        ""x"" : 26.32,
        ""y"" : 108.24
      }, {
        ""x"" : 28.82,
        ""y"" : 111.62
      }, {
        ""x"" : 31.33,
        ""y"" : 114.9
      }, {
        ""x"" : 33.83,
        ""y"" : 118.06
      }, {
        ""x"" : 36.34,
        ""y"" : 121.06
      }, {
        ""x"" : 38.85,
        ""y"" : 123.88
      }, {
        ""x"" : 41.35,
        ""y"" : 126.5
      }, {
        ""x"" : 43.86,
        ""y"" : 128.91
      }, {
        ""x"" : 46.37,
        ""y"" : 131.09
      }, {
        ""x"" : 48.87,
        ""y"" : 133.02
      }, {
        ""x"" : 51.38,
        ""y"" : 134.71
      }, {
        ""x"" : 53.88,
        ""y"" : 136.13
      }, {
        ""x"" : 56.39,
        ""y"" : 137.29
      }, {
        ""x"" : 58.9,
        ""y"" : 138.18
      }, {
        ""x"" : 61.4,
        ""y"" : 138.82
      }, {
        ""x"" : 63.91,
        ""y"" : 139.19
      }, {
        ""x"" : 66.42,
        ""y"" : 139.32
      }, {
        ""x"" : 68.92,
        ""y"" : 139.21
      }, {
        ""x"" : 71.43,
        ""y"" : 138.86
      }, {
        ""x"" : 73.93,
        ""y"" : 138.31
      }, {
        ""x"" : 76.44,
        ""y"" : 137.56
      }, {
        ""x"" : 78.95,
        ""y"" : 136.63
      }, {
        ""x"" : 81.45,
        ""y"" : 135.54
      }, {
        ""x"" : 83.96,
        ""y"" : 134.31
      }, {
        ""x"" : 86.47,
        ""y"" : 132.97
      }, {
        ""x"" : 88.97,
        ""y"" : 131.53
      }, {
        ""x"" : 91.48,
        ""y"" : 130.02
      }, {
        ""x"" : 93.98,
        ""y"" : 128.45
      }, {
        ""x"" : 96.49,
        ""y"" : 126.85
      }, {
        ""x"" : 99,
        ""y"" : 125.24
      }, {
        ""x"" : 101.5,
        ""y"" : 123.62
      }, {
        ""x"" : 104.01,
        ""y"" : 122.02
      }, {
        ""x"" : 106.52,
        ""y"" : 120.46
      }, {
        ""x"" : 109.02,
        ""y"" : 118.95
      }, {
        ""x"" : 111.53,
        ""y"" : 117.49
      }, {
        ""x"" : 114.04,
        ""y"" : 116.11
      }, {
        ""x"" : 116.54,
        ""y"" : 114.8
      }, {
        ""x"" : 119.05,
        ""y"" : 113.58
      }, {
        ""x"" : 121.55,
        ""y"" : 112.45
      }, {
        ""x"" : 124.06,
        ""y"" : 111.41
      }, {
        ""x"" : 126.57,
        ""y"" : 110.46
      }, {
        ""x"" : 129.07,
        ""y"" : 109.61
      }, {
        ""x"" : 131.58,
        ""y"" : 108.84
      }, {
        ""x"" : 134.09,
        ""y"" : 108.17
      }, {
        ""x"" : 136.59,
        ""y"" : 107.59
      }, {
        ""x"" : 139.1,
        ""y"" : 107.09
      }, {
        ""x"" : 141.6,
        ""y"" : 106.66
      }, {
        ""x"" : 144.11,
        ""y"" : 106.31
      }, {
        ""x"" : 146.62,
        ""y"" : 106.02
      }, {
        ""x"" : 149.12,
        ""y"" : 105.78
      }, {
        ""x"" : 151.63,
        ""y"" : 105.59
      }, {
        ""x"" : 154.14,
        ""y"" : 105.44
      }, {
        ""x"" : 156.64,
        ""y"" : 105.31
      }, {
        ""x"" : 159.15,
        ""y"" : 105.21
      }, {
        ""x"" : 161.65,
        ""y"" : 105.11
      }, {
        ""x"" : 164.16,
        ""y"" : 105
      }, {
        ""x"" : 166.67,
        ""y"" : 104.89
      }, {
        ""x"" : 169.17,
        ""y"" : 104.75
      }, {
        ""x"" : 171.68,
        ""y"" : 104.57
      }, {
        ""x"" : 174.19,
        ""y"" : 104.36
      }, {
        ""x"" : 176.69,
        ""y"" : 104.09
      }, {
        ""x"" : 179.2,
        ""y"" : 103.76
      }, {
        ""x"" : 181.7,
        ""y"" : 103.36
      }, {
        ""x"" : 184.21,
        ""y"" : 102.87
      }, {
        ""x"" : 186.72,
        ""y"" : 102.31
      }, {
        ""x"" : 189.22,
        ""y"" : 101.65
      }, {
        ""x"" : 191.73,
        ""y"" : 100.89
      }, {
        ""x"" : 194.24,
        ""y"" : 100.03
      }, {
        ""x"" : 196.74,
        ""y"" : 99.07
      }, {
        ""x"" : 199.25,
        ""y"" : 98
      }, {
        ""x"" : 201.75,
        ""y"" : 96.83
      }, {
        ""x"" : 204.26,
        ""y"" : 95.55
      }, {
        ""x"" : 206.77,
        ""y"" : 94.16
      }, {
        ""x"" : 209.27,
        ""y"" : 92.68
      }, {
        ""x"" : 211.78,
        ""y"" : 91.11
      }, {
        ""x"" : 214.29,
        ""y"" : 89.46
      }, {
        ""x"" : 216.79,
        ""y"" : 87.73
      }, {
        ""x"" : 219.3,
        ""y"" : 85.95
      }, {
        ""x"" : 221.8,
        ""y"" : 84.13
      }, {
        ""x"" : 224.31,
        ""y"" : 82.27
      }, {
        ""x"" : 226.82,
        ""y"" : 80.41
      }, {
        ""x"" : 229.32,
        ""y"" : 78.51
      }, {
        ""x"" : 231.83,
        ""y"" : 76.58
      }, {
        ""x"" : 234.34,
        ""y"" : 74.61
      }, {
        ""x"" : 236.84,
        ""y"" : 72.61
      }, {
        ""x"" : 239.35,
        ""y"" : 70.58
      }, {
        ""x"" : 241.85,
        ""y"" : 68.53
      }, {
        ""x"" : 244.36,
        ""y"" : 66.5
      }, {
        ""x"" : 246.87,
        ""y"" : 64.48
      }, {
        ""x"" : 249.37,
        ""y"" : 62.51
      }, {
        ""x"" : 251.88,
        ""y"" : 60.61
      }, {
        ""x"" : 254.39,
        ""y"" : 58.79
      }, {
        ""x"" : 256.89,
        ""y"" : 57.09
      }, {
        ""x"" : 259.4,
        ""y"" : 55.53
      }, {
        ""x"" : 261.9,
        ""y"" : 54.12
      }, {
        ""x"" : 264.41,
        ""y"" : 52.89
      }, {
        ""x"" : 266.92,
        ""y"" : 51.86
      }, {
        ""x"" : 269.42,
        ""y"" : 51.05
      }, {
        ""x"" : 271.93,
        ""y"" : 50.46
      }, {
        ""x"" : 274.44,
        ""y"" : 50.1
      }, {
        ""x"" : 276.94,
        ""y"" : 50
      }, {
        ""x"" : 279.45,
        ""y"" : 50.15
      }, {
        ""x"" : 281.95,
        ""y"" : 50.55
      }, {
        ""x"" : 284.46,
        ""y"" : 51.21
      }, {
        ""x"" : 286.97,
        ""y"" : 52.11
      }, {
        ""x"" : 289.47,
        ""y"" : 53.26
      }, {
        ""x"" : 291.98,
        ""y"" : 54.64
      }, {
        ""x"" : 294.49,
        ""y"" : 56.24
      }, {
        ""x"" : 296.99,
        ""y"" : 58.04
      }, {
        ""x"" : 299.5,
        ""y"" : 60.02
      }, {
        ""x"" : 302.01,
        ""y"" : 62.15
      }, {
        ""x"" : 304.51,
        ""y"" : 64.43
      }, {
        ""x"" : 307.02,
        ""y"" : 66.81
      }, {
        ""x"" : 309.52,
        ""y"" : 69.28
      }, {
        ""x"" : 312.03,
        ""y"" : 71.8
      }, {
        ""x"" : 314.54,
        ""y"" : 74.35
      }, {
        ""x"" : 317.04,
        ""y"" : 76.89
      }, {
        ""x"" : 319.55,
        ""y"" : 79.41
      }, {
        ""x"" : 322.06,
        ""y"" : 81.87
      }, {
        ""x"" : 324.56,
        ""y"" : 84.24
      }, {
        ""x"" : 327.07,
        ""y"" : 86.51
      }, {
        ""x"" : 329.57,
        ""y"" : 88.66
      }, {
        ""x"" : 332.08,
        ""y"" : 90.67
      }, {
        ""x"" : 334.59,
        ""y"" : 92.53
      }, {
        ""x"" : 337.09,
        ""y"" : 94.25
      }, {
        ""x"" : 339.6,
        ""y"" : 95.81
      }, {
        ""x"" : 342.11,
        ""y"" : 97.24
      }, {
        ""x"" : 344.61,
        ""y"" : 98.55
      }, {
        ""x"" : 347.12,
        ""y"" : 99.78
      }, {
        ""x"" : 349.62,
        ""y"" : 100.96
      }, {
        ""x"" : 352.13,
        ""y"" : 102.15
      }, {
        ""x"" : 354.64,
        ""y"" : 103.41
      }, {
        ""x"" : 357.14,
        ""y"" : 104.79
      }, {
        ""x"" : 359.65,
        ""y"" : 106.32
      }, {
        ""x"" : 362.16,
        ""y"" : 108.04
      }, {
        ""x"" : 364.66,
        ""y"" : 109.95
      }, {
        ""x"" : 367.17,
        ""y"" : 112.06
      }, {
        ""x"" : 369.67,
        ""y"" : 114.38
      }, {
        ""x"" : 372.18,
        ""y"" : 116.88
      }, {
        ""x"" : 374.69,
        ""y"" : 119.57
      }, {
        ""x"" : 377.19,
        ""y"" : 122.42
      }, {
        ""x"" : 379.7,
        ""y"" : 125.4
      }, {
        ""x"" : 382.21,
        ""y"" : 128.49
      }, {
        ""x"" : 384.71,
        ""y"" : 131.66
      }, {
        ""x"" : 387.22,
        ""y"" : 134.89
      }, {
        ""x"" : 389.72,
        ""y"" : 138.13
      }, {
        ""x"" : 392.23,
        ""y"" : 141.35
      }, {
        ""x"" : 394.74,
        ""y"" : 144.53
      }, {
        ""x"" : 397.24,
        ""y"" : 147.63
      }, {
        ""x"" : 399.75,
        ""y"" : 150.62
      }, {
        ""x"" : 402.26,
        ""y"" : 153.47
      }, {
        ""x"" : 404.76,
        ""y"" : 156.16
      }, {
        ""x"" : 407.27,
        ""y"" : 158.65
      }, {
        ""x"" : 409.77,
        ""y"" : 160.92
      }, {
        ""x"" : 412.28,
        ""y"" : 162.97
      }, {
        ""x"" : 414.79,
        ""y"" : 164.76
      }, {
        ""x"" : 417.29,
        ""y"" : 166.28
      }, {
        ""x"" : 419.8,
        ""y"" : 167.54
      }, {
        ""x"" : 422.31,
        ""y"" : 168.51
      }, {
        ""x"" : 424.81,
        ""y"" : 169.19
      }, {
        ""x"" : 427.32,
        ""y"" : 169.59
      }, {
        ""x"" : 429.82,
        ""y"" : 169.71
      }, {
        ""x"" : 432.33,
        ""y"" : 169.56
      }, {
        ""x"" : 434.84,
        ""y"" : 169.14
      }, {
        ""x"" : 437.34,
        ""y"" : 168.46
      }, {
        ""x"" : 439.85,
        ""y"" : 167.55
      }, {
        ""x"" : 442.36,
        ""y"" : 166.42
      }, {
        ""x"" : 444.86,
        ""y"" : 165.1
      }, {
        ""x"" : 447.37,
        ""y"" : 163.59
      }, {
        ""x"" : 449.87,
        ""y"" : 161.93
      }, {
        ""x"" : 452.38,
        ""y"" : 160.13
      }, {
        ""x"" : 454.89,
        ""y"" : 158.23
      }, {
        ""x"" : 457.39,
        ""y"" : 156.24
      }, {
        ""x"" : 459.9,
        ""y"" : 154.19
      }, {
        ""x"" : 462.41,
        ""y"" : 152.09
      }, {
        ""x"" : 464.91,
        ""y"" : 149.97
      }, {
        ""x"" : 467.42,
        ""y"" : 147.83
      }, {
        ""x"" : 469.92,
        ""y"" : 145.7
      }, {
        ""x"" : 472.43,
        ""y"" : 143.57
      }, {
        ""x"" : 474.94,
        ""y"" : 141.45
      }, {
        ""x"" : 477.44,
        ""y"" : 139.32
      }, {
        ""x"" : 479.95,
        ""y"" : 137.1
      }, {
        ""x"" : 482.46,
        ""y"" : 134.74
      }, {
        ""x"" : 484.96,
        ""y"" : 132.21
      }, {
        ""x"" : 487.47,
        ""y"" : 129.46
      }, {
        ""x"" : 489.97,
        ""y"" : 126.48
      }, {
        ""x"" : 492.48,
        ""y"" : 123.26
      }, {
        ""x"" : 494.99,
        ""y"" : 119.8
      }, {
        ""x"" : 497.49,
        ""y"" : 116.1
      }, {
        ""x"" : 500,
        ""y"" : 112.18
      } ]
    }
  },
  ""players"" : [ {
    ""name"" : ""42"",
    ""color"" : ""0xa7a77d""
  }, {
    ""name"" : ""Artur"",
    ""color"" : ""0xa7531e""
  }, {
    ""name"" : ""choke"",
    ""color"" : ""0xed1569""
  }, {
    ""name"" : ""OpenTank"",
    ""color"" : ""0xb9e82d""
  }, {
    ""name"" : ""Sheep"",
    ""color"" : ""0xb06322""
  }, {
    ""name"" : ""ArrowTeam"",
    ""color"" : ""0xa4b205""
  } ],
  ""round"" : 24,
  ""initialPositions"" : {
    ""choke"" : {
      ""x"" : -25.43,
      ""y"" : 59.07
    },
    ""OpenTank"" : {
      ""x"" : 62.43,
      ""y"" : 138.97
    },
    ""Artur"" : {
      ""x"" : -219.29,
      ""y"" : 108.81
    },
    ""Sheep"" : {
      ""x"" : 168.29,
      ""y"" : 104.8
    },
    ""ArrowTeam"" : {
      ""x"" : 393.14,
      ""y"" : 142.51
    },
    ""42"" : {
      ""x"" : -378.14,
      ""y"" : 95.73
    }
  }
}";
    }
}