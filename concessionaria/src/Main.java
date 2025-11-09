import java.util.ArrayList;
import java.util.Scanner;
import java.io.*;

public class Main {
    static Scanner sc = new Scanner(System.in);
    static ArrayList<Vendedor> vendedores = new ArrayList<>();
    static ArrayList<Cliente> clientes = new ArrayList<>();
    static ArrayList<Veiculo> veiculos = new ArrayList<>();
    static ArrayList<Atividade> atividades = new ArrayList<>();

    static final String ARQUIVO_VEICULOS = "veiculos.txt";
    static final String ARQUIVO_VENDEDORES = "vendedores.txt";
    static final String ARQUIVO_CLIENTES = "clientes.txt";

    public static void main(String[] args) {
        carregarVendedores();
        carregarClientes();
        carregarVeiculos();

        if (!vendedores.isEmpty() && !clientes.isEmpty() && !veiculos.isEmpty()) {
            atividades.add(new Atividade(vendedores.get(0), clientes.get(0), veiculos.get(0), "reserva"));
            atividades.add(new Atividade(vendedores.get(0), clientes.get(3), veiculos.get(1), "reserva"));
        }

        int escolha;
        do {
            System.out.println("==================");
            System.out.println("Concessionaria");
            System.out.println("==================");
            System.out.println("1. Registro");
            System.out.println("2. Login");
            System.out.println("3. Sair");
            System.out.print("Escolha: ");
            escolha = sc.nextInt();
            sc.nextLine();

            switch (escolha) {
                case 1: telaRegistro(); break;
                case 2: telaLogin(); break;
                case 3: System.out.println("Encerrando..."); break;
                default: System.out.println("Opção inválida!");
            }
        } while (escolha != 3);
    }

    private static void telaRegistro() {
        System.out.println("\n=== Registro de vendedor ===");
        System.out.print("Nome: ");
        String nome = sc.nextLine();
        System.out.print("Login: ");
        String login = sc.nextLine();
        System.out.print("Senha: ");
        String senha = sc.nextLine();
        Vendedor novo = new Vendedor(nome, login, senha);
        vendedores.add(novo);
        salvarVendedores();
        System.out.println("Vendedor registrado com sucesso!\n");
    }

    private static void telaLogin() {
        System.out.println("\n=== Login de vendedor ===");
        System.out.print("Login: ");
        String login = sc.nextLine();
        System.out.print("Senha: ");
        String senha = sc.nextLine();
        for (Vendedor v : vendedores) {
            if (v.getLogin().equals(login) && v.getSenha().equals(senha)) {
                System.out.println("\nBem-vindo, " + v.getNome() + "!\n");
                menuVendedor(v);
                return;
            }
        }
        System.out.println("Login ou senha incorretos.\n");
    }

    private static void menuVendedor(Vendedor v) {
        int opcao;
        do {
            System.out.println("==================");
            System.out.println("Menu do Vendedor - " + v.getNome());
            System.out.println("==================");
            System.out.println("1. Compra");
            System.out.println("2. Venda");
            System.out.println("3. Minhas reservas");
            System.out.println("4. Listar clientes");
            System.out.println("5. Listar veiculos");
            System.out.println("0. Sair");
            System.out.print("Escolha: ");
            opcao = sc.nextInt();
            sc.nextLine();

            switch (opcao) {
                case 1: System.out.println("\n--- Tela de Compra ---\n"); break;
                case 2: System.out.println("\n--- Tela de Venda ---\n"); break;
                case 3:
                    System.out.println("\n--- Minhas Reservas ---\n");
                    boolean encontrou = false;
                    for (Atividade a : atividades) {
                        if (a.getTipo().equalsIgnoreCase("reserva") && a.getVendedor().equals(v)) {
                            a.exibirInfo();
                            encontrou = true;
                        }
                    }
                    if (!encontrou) {
                        System.out.println("Nenhuma reserva encontrada para este vendedor.\n");
                    }
                    break;
                case 4:
                    System.out.println("\n--- Tela de Clientes ---\n");
                    for (Cliente c : clientes) c.exibirInfo();
                    break;
                case 5:
                    System.out.println("\n--- Tela de Veículos ---\n");
                    for (Veiculo ve : veiculos) ve.exibirInfo();
                    break;
                case 0: System.out.println("Saindo do menu do vendedor...\n"); break;
                default: System.out.println("Opção inválida!\n");
            }
        } while (opcao != 0);
    }

    private static void salvarVendedores() {
        try (PrintWriter pw = new PrintWriter(new FileWriter(ARQUIVO_VENDEDORES))) {
            for (Vendedor v : vendedores) {
                pw.println(v.getNome() + ";" + v.getLogin() + ";" + v.getSenha());
            }
        } catch (IOException e) { System.out.println("Erro ao salvar vendedores: " + e.getMessage()); }
    }

    private static void carregarVendedores() {
        File arquivo = new File(ARQUIVO_VENDEDORES);
        if (!arquivo.exists()) return;
        try (BufferedReader br = new BufferedReader(new FileReader(ARQUIVO_VENDEDORES))) {
            String linha;
            while ((linha = br.readLine()) != null) {
                String[] partes = linha.split(";");
                if (partes.length == 3) vendedores.add(new Vendedor(partes[0], partes[1], partes[2]));
            }
        } catch (IOException e) { System.out.println("Erro ao carregar vendedores: " + e.getMessage()); }
    }

    private static void carregarClientes() {
        File arquivo = new File(ARQUIVO_CLIENTES);
        if (!arquivo.exists()) return;
        try (BufferedReader br = new BufferedReader(new FileReader(ARQUIVO_CLIENTES))) {
            String linha;
            while ((linha = br.readLine()) != null) {
                String[] partes = linha.split(";");
                if (partes.length == 2) clientes.add(new Cliente(partes[0], partes[1]));
            }
        } catch (IOException e) { System.out.println("Erro ao carregar clientes: " + e.getMessage()); }
    }

    private static void carregarVeiculos() {
        File arquivo = new File(ARQUIVO_VEICULOS);
        if (!arquivo.exists()) return;
        try (BufferedReader br = new BufferedReader(new FileReader(ARQUIVO_VEICULOS))) {
            String linha;
            while ((linha = br.readLine()) != null) {
                String[] partes = linha.split(";");
                if (partes.length == 3) {
                    veiculos.add(new Veiculo(partes[0], partes[1], Double.parseDouble(partes[2])));
                }
            }
        } catch (IOException e) { System.out.println("Erro ao carregar veículos: " + e.getMessage()); }
    }
}
