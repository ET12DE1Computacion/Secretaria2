namespace DominioSecretaria.InfoPersonal
{
    public class Domicilio
    {
        public int IdDomicilio { get; set; }
        
        public virtual Localidad Localidad { get; set; }
        
        public string Calle { get; set; }
        
        public int? Altura { get; set; }
        
        public byte? Piso { get; set; }
        
        public string Departamento { get; set; }
        
        public string CodigoPostal { get; set; }
        
        public string observacionDomicilio { get; set; }
        
        public Domicilio() { }
        
        public Domicilio(Localidad localidad)
        {
            this.Localidad = localidad;
        }
    }
}