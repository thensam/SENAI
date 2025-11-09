public class Vendedor {
    private String nome;
    private String login;
    private String senha;

    public Vendedor(String nome, String login, String senha){
        this.nome = nome;
        this.login = login;
        this.senha = senha;
    }
    public String getNome(){
        return nome;
    }
    public String getLogin(){
        return login;
    }
    public String getSenha() {
        return senha;
    }
    public String toString(){
        return "Vendedor "+nome+" Login "+login+" ";
    }
}