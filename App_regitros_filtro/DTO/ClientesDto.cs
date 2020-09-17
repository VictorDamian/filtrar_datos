namespace App_regitros_filtro.DTO
{
    class ClientesDto
    {
        //ATRIBUTOS
        int _ID;
        string _nombre;
        string _apellido;
        string _direccion;
        string _ciudad;
        string _email;
        string _telefono;
        string _ocupacion;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Ocupacion { get => _ocupacion; set => _ocupacion = value; }
        //PROPIEDADES GET Y SET
    }
}
