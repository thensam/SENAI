public class Veiculo {
    private String modelo;
    private String placa;
    private double preco;

    public Veiculo(String modelo, String placa, double preco) {
        this.modelo = modelo;
        this.placa = placa;
        this.preco = preco;
    }
    public String getModelo() { return modelo; }
    public String getPlaca() { return placa; }
    public double getPreco() { return preco; }

    public void exibirInfo() {
        System.out.println(modelo + " - Placa: " + placa + " - R$" + preco);
    }
}
