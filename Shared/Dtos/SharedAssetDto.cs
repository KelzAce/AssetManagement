using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Shared.Enums.AssetEnum;

namespace Shared.Dtos
{
    public class SharedAssetDto
    {
        public class CreateAssetDto
        {
            public required string Project { get; set; }

            [JsonConverter(typeof(JsonStringEnumConverter))]
            public ProjectType ProjectType { get; set; }

            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MinistryName Ministry { get; set; }

            [JsonConverter(typeof(JsonStringEnumConverter))]
            public string Doc { get; set; }
        }

        public class CreateAssetResponseDto : CreateAssetDto
        {

        }

        public class GetAssetDto
        {

        }

        public class GetAssetResponseDto
        {

        }

    }

}
