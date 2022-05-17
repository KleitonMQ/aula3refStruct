public ref struct Pessoa
{
    public int idade { get; set; }
    public string nome { get; set; }

    public Endereco enderecoPessoa { get; set; }

}

public ref struct Endereco
{
    public int numero { get; set; }
    public string logradouro { get; set; }
    public string cep { get; set; }
    public string cidade { get; set; }
}

//structs permitem implementar interface
//ref structs não permitem implementar interface
//ref struct não pode usar nada que tenha chance de cair na heap, por isso ela não pode ficar junto nem das structs.
