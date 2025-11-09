public class Atividade {
    private Vendedor vendedor;
    private Cliente cliente;
    private Veiculo veiculo;
    private String tipo;

    public Atividade(Vendedor vendedor, Cliente cliente, Veiculo veiculo, String tipo) {
        this.vendedor = vendedor;
        this.cliente = cliente;
        this.veiculo = veiculo;
        this.tipo = tipo;
    }

    public void exibirInfo() {
        System.out.println(tipo.toUpperCase() + " | " +
                "Vendedor: " + vendedor.getNome() +
                " | Cliente: " + cliente.getNome() +
                " | Veículo: " + veiculo.getModelo());
    }

    public Vendedor getVendedor() {
        return vendedor;
    }
    public String getTipo() {
        return tipo;
    }
}
