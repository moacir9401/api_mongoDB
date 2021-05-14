using System;
using MongoDB.Driver.GeoJsonObjectModel;


namespace Api.Data.Collections
{
    public class Infectado
    {  
        public DateTime DataNascimento { get; set; }
        public string sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }

        public Infectado(DateTime dataNacimento, string sexo,double latitude, double longitude){
            this.DataNascimento = dataNacimento;
            this.sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

    }
}