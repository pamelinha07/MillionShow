namespace Trolls3;

public class Gerenciador
{

    List <Questao> listaQuestoes = new List<Questao>();
    List <int> listaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;

    public int Pontuacao{get; private set;}

    Label labelPontuacao;
    Label labelNivel;
    int NivelResposta = 1;
    
    void Inicializar ()
    {
        Pontuacao = 0;
        NivelResposta = 1;
        ProximaQuestao();
    }

    public Gerenciador(Label labelPergunta, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label LabelNivel, Label LabelPontuacao){
        CriarQuestoes(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        this.labelNivel = labelNivel;
        this.labelPontuacao = labelPontuacao;
    }

     void CriarQuestoes (Label labelPergunta, Button buttonResp01, Button buttonResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
     {
        var q1 = new Questao();
        q1.Nivelresposta = 1;
        q1.Pergunta= "Qual o nome do meu cachorro?";
        q1.Resposta1 ="Trovao";
        q1.Resposta2 ="Fiote";
        q1.Resposta3 ="Jeredy";
        q1.Resposta4 ="Chico";
        q1.Resposta5 ="Bob";

        q1.Respostacorreta = 2;
        q1.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q1);

        var q2 = new Questao();
        q2.Nivelresposta = 1;

        q2.Pergunta = "Qual o apelido que a Suki deu ao Brian em Velozes e Furiosos 2?";
        q2.Resposta1 = "Bullet";
        q2.Resposta2 = "Junin";
        q2.Resposta3 = "Skyline";
        q2.Resposta4 = "Bola 8";
        q2.Resposta5 = "Branquelo";
        q2.Respostacorreta = 1;
        q2.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q2);

        var q3 = new Questao();
        q3.Nivelresposta = 1;

        q3.Pergunta = "Qual a capital da França?";
        q3.Resposta1 = "Paris";
        q3.Resposta2 = "Londres";
        q3.Resposta3 = "Berlim";
        q3.Resposta4 = "Madrid";
        q3.Resposta5 = "Roma";
        q3.Respostacorreta = 1;

        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Nivelresposta = 1;

        q4.Pergunta = "Quem pintou a Mona Lisa?";
        q4.Resposta1 = "Van Gogh";
        q4.Resposta2 = "Picasso";
        q4.Resposta3 = "Da Vinci";
        q4.Resposta4 = "Monet";
        q4.Resposta5 = "Rembrandt";
        q4.Respostacorreta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Nivelresposta = 1;

        q5.Pergunta = "Qual é o meu esporte favorito?";
        q5.Resposta1 = "Futebol";
        q5.Resposta2 = "Basquete";
        q5.Resposta3 = "Natação";
        q5.Resposta4 = "Vôlei";
        q5.Resposta5 = "Tênis";
        q5.Respostacorreta = 1;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Nivelresposta = 1;

        q6.Pergunta = "Qual a minha série favorita?";
        q6.Resposta1 = "Csi";
        q6.Resposta2 = "Greys Anatomy";
        q6.Resposta3 = "Elite";
        q6.Resposta4 = "Stranger Things";
        q6.Resposta5 = "Flash";
        q6.Respostacorreta = 1;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Nivelresposta = 1;

        q7.Pergunta = "Qual é o maior planeta do sistema solar?";
        q7.Resposta1 = "Terra";
        q7.Resposta2 = "Marte";
        q7.Resposta3 = "Júpiter";
        q7.Resposta4 = "Saturno";
        q7.Resposta5 = "Urano";
        q7.Respostacorreta = 3;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Nivelresposta = 1;

        q8.Pergunta = "Qual é o animal terrestre mais rápido?";
        q8.Resposta1 = "Leão";
        q8.Resposta2 = "Guepardo";
        q8.Resposta3 = "Cavalo";
        q8.Resposta4 = "Tigre";
        q8.Resposta5 = "Elefante";
        q8.Respostacorreta = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Nivelresposta = 1;

        q9.Pergunta = "Qual é o animal símbolo do Brasil?";
        q9.Resposta1 = "Tigre";
        q9.Resposta2 = "Onça-pintada";
        q9.Resposta3 = "Leão";
        q9.Resposta4 = "Urso";
        q9.Resposta5 = "Lobo";
        q9.Respostacorreta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Nivelresposta = 1;

        q10.Pergunta = "Em qual país fica a Torre Eiffel?";
        q10.Resposta1 = "Alemanha";
        q10.Resposta2 = "França";
        q10.Resposta3 = "Itália";
        q10.Resposta4 = "Espanha";
        q10.Resposta5 = "Portugal";
        q10.Respostacorreta = 2;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q10);

        var q11 = new Questao();
        q11.Nivelresposta = 2;

        q11.Pergunta = "Qual a minha cor favorita?";
        q11.Resposta1 = "Azul";
        q11.Resposta2 = "Verde";
        q11.Resposta3 = "Vermelho";
        q11.Resposta4 = "Amarelo";
        q11.Resposta5 = "Preto";
        q11.Respostacorreta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q11);

        var q12 = new Questao();
        q12.Nivelresposta = 2;

        q12.Pergunta = "Qual é o maior animal terrestre?";
        q12.Resposta1 = "Elefante";
        q12.Resposta2 = "Girafa";
        q12.Resposta3 = "Rinoceronte";
        q12.Resposta4 = "Hipopótamo";
        q12.Resposta5 = "Urso";
        q12.Respostacorreta = 1;
        q12.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q12);

        var q13 = new Questao();
        q13.Nivelresposta = 2;

        q13.Pergunta = "Qual o meu hobby favorito?";
        q13.Resposta1 = "Cozinhar";
        q13.Resposta2 = "Viajar";
        q13.Resposta3 = "Ler";
        q13.Resposta4 = "Correr";
        q13.Resposta5 = "Jogar videogame";
        q13.Respostacorreta = 4;
        q13.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q13);

        var q14 = new Questao();
        q14.Nivelresposta = 2;

        q14.Pergunta = "Qual a minha bebida favorita?";
        q14.Resposta1 = "Água";
        q14.Resposta2 = "Cerveja";
        q14.Resposta3 = "Refrigerante";
        q14.Resposta4 = "Suco";
        q14.Resposta5 = "Vinho";
        q14.Respostacorreta = 4;
        q14.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q14);

        var q15 = new Questao();
        q15.Nivelresposta = 2;

        q15.Pergunta = "Qual o meu destino de férias favorito?";
        q15.Resposta1 = "Praia";
        q15.Resposta2 = "Montanha";
        q15.Resposta3 = "Cidade";
        q15.Resposta4 = "Campo";
        q15.Resposta5 = "Estrangeiro";
        q15.Respostacorreta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q15);

        var q16 = new Questao();
        q16.Nivelresposta = 2;

        q16.Pergunta = "Qual a minha estação do ano favorita?";
        q16.Resposta1 = "Verão";
        q16.Resposta2 = "Inverno";
        q16.Resposta3 = "Primavera";
        q16.Resposta4 = "Outono";
        q16.Resposta5 = "Nenhuma";
        q16.Respostacorreta = 1;
        q16.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q16);

        var q17 = new Questao();
        q17.Nivelresposta = 2;

        q17.Pergunta = "Qual o meu super-herói favorito?";
        q17.Resposta1 = "Superman";
        q17.Resposta2 = "Batman";
        q17.Resposta3 = "Spider-Man";
        q17.Resposta4 = "Iron Man";
        q17.Resposta5 = "Thor";
        q17.Respostacorreta = 2;
        q17.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q17);

        var q18 = new Questao();
        q18.Nivelresposta = 2;

        q18.Pergunta = "Qual é a capital do Brasil?";
        q18.Resposta1 = "Rio de Janeiro";
        q18.Resposta2 = "São Paulo";
        q18.Resposta3 = "Brasília";
        q18.Resposta4 = "Belo Horizonte";
        q18.Resposta5 = "Salvador";
        q18.Respostacorreta = 3;
        q18.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q18);

        var q19 = new Questao();
        q19.Nivelresposta = 2;

        q19.Pergunta = "Qual planeta é conhecido como o Planeta Vermelho?";
        q19.Resposta1 = "Terra";
        q19.Resposta2 = "Marte";
        q19.Resposta3 = "Vênus";
        q19.Resposta4 = "Júpiter";
        q19.Resposta5 = "Saturno";
        q19.Respostacorreta = 2;
        q19.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q19);

        var q20 = new Questao();
        q20.Nivelresposta = 2;

        q20.Pergunta = "Qual a minha profissão dos sonhos?";
        q20.Resposta1 = "Médica";
        q20.Resposta2 = "Engenheira";
        q20.Resposta3 = "Artista";
        q20.Resposta4 = "Zootecnista";
        q20.Resposta5 = "Cientista";
        q20.Respostacorreta = 4;
        q20.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q20);

        var q21 = new Questao();
        q21.Nivelresposta = 3;

        q21.Pergunta = "Qual é o maior deserto do mundo?";
        q21.Resposta1 = "Sahara";
        q21.Resposta2 = "Gobi";
        q21.Resposta3 = "Ártico";
        q21.Resposta4 = "Antártico";
        q21.Resposta5 = "Kalahari";
        q21.Respostacorreta = 4;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q21);

        var q22 = new Questao();
        q22.Nivelresposta = 3;

        q22.Pergunta = "Qual o meu passatempo preferido?";
        q22.Resposta1 = "Jogar bola";
        q22.Resposta2 = "Jogar video-game";
        q22.Resposta3 = "Ler";
        q22.Resposta4 = "Dormir";
        q22.Resposta5 = "Cozinhar";
        q22.Respostacorreta = 1;
        q22.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q22);

        var q23 = new Questao();
        q23.Nivelresposta = 3;

        q23.Pergunta = "Qual a minha cidade natal?";
        q23.Resposta1 = "Apucarana";
        q23.Resposta2 = "Londrina";
        q23.Resposta3 = "Maringa";
        q23.Resposta4 = "Mandaguari";
        q23.Resposta5 = "Rolândia";
        q23.Respostacorreta = 1;
        q23.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q23);

        var q24 = new Questao();
        q24.Nivelresposta = 3;
        q24.Pergunta = "Qual o meu jogo de tabuleiro favorito?";
        q24.Resposta1 = "Banco Imobiliário";
        q24.Resposta2 = "War";
        q24.Resposta3 = "Detetive";
        q24.Resposta4 = "Xadrez";
        q24.Resposta5 = "Jogo da Vida";
        q24.Respostacorreta = 3;
        q24.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q24);

        // Pergunta 25
        var q25 = new Questao();
        q25.Nivelresposta = 3;
        q25.Pergunta = "Qual a minha série animada favorita?";
        q25.Resposta1 = "Os Simpsons";
        q25.Resposta2 = "Rick and Morty";
        q25.Resposta3 = "Avatar: A Lenda de Aang";
        q25.Resposta4 = "Bob Esponja";
        q25.Resposta5 = "Futurama";
        q25.Respostacorreta = 4;
        q25.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q25);

        // Pergunta 26
        var q26 = new Questao();
        q26.Nivelresposta = 3;
        q26.Pergunta = "Qual o meu esporte olímpico favorito?";
        q26.Resposta1 = "Natação";
        q26.Resposta2 = "Atletismo";
        q26.Resposta3 = "Ginástica";
        q26.Resposta4 = "Futebol";
        q26.Resposta5 = "Vôlei";
        q26.Respostacorreta = 4;
        q26.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q26);

        // Pergunta 27
        var q27 = new Questao();
        q27.Nivelresposta = 3;
        q27.Pergunta = "Qual o meu animal de estimação?";
        q27.Resposta1 = "Cachorro";
        q27.Resposta2 = "Gato";
        q27.Resposta3 = "Peixe";
        q27.Resposta4 = "Pássaro";
        q27.Resposta5 = "Hamster";
        q27.Respostacorreta = 1;
        q27.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q27);

        // Pergunta 28
        var q28 = new Questao();
        q28.Nivelresposta = 3;
        q28.Pergunta = "Qual é o principal componente do gás natural?";
        q28.Resposta1 = "Propano";
        q28.Resposta2 = "Metano";
        q28.Resposta3 = "Butano";
        q28.Resposta4 = "Etano";
        q28.Resposta5 = "Acetileno";
        q28.Respostacorreta = 2;
        q28.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q28);

        // Pergunta 29
        var q29 = new Questao();
        q29.Nivelresposta = 3;
        q29.Pergunta = "Qual é o símbolo químico do oxigênio?";
        q29.Resposta1 = "O";
        q29.Resposta2 = "O2";
        q29.Resposta3 = "H2O";
        q29.Resposta4 = "C";
        q29.Resposta5 = "N";
        q29.Respostacorreta = 1;
        q29.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q29);

        // Pergunta 30
        var q30 = new Questao();
        q30.Nivelresposta = 3;
        q30.Pergunta = "Qual a minha atividade preferida ao ar livre?";
        q30.Resposta1 = "Correr";
        q30.Resposta2 = "Ciclismo";
        q30.Resposta3 = "Piquenique";
        q30.Resposta4 = "Camping";
        q30.Resposta5 = "Natação";
        q30.Respostacorreta = 1;
        q30.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q30);

        // Pergunta 31
        var q31 = new Questao();
        q31.Nivelresposta = 4;
        q31.Pergunta = "Qual o meu dia da semana favorito?";
        q31.Resposta1 = "Segunda-feira";
        q31.Resposta2 = "Sexta-feira";
        q31.Resposta3 = "Sábado";
        q31.Resposta4 = "Domingo";
        q31.Resposta5 = "Quarta-feira";
        q31.Respostacorreta = 3;
        q31.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q31);

        // Pergunta 32
        var q32 = new Questao();
        q32.Nivelresposta = 4;
        q32.Pergunta = "Qual o meu mês favorito do ano?";
        q32.Resposta1 = "Janeiro";
        q32.Resposta2 = "Junho";
        q32.Resposta3 = "Dezembro";
        q32.Resposta4 = "Setembro";
        q32.Resposta5 = "Abril";
        q32.Respostacorreta = 3;
        q32.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q32);

        // Pergunta 33
        var q33 = new Questao();
        q33.Nivelresposta = 4;
        q33.Pergunta = "Qual é a montanha mais alta do mundo?";
        q33.Resposta1 = "K2";
        q33.Resposta2 = "Kilimanjaro";
        q33.Resposta3 = "Everest";
        q33.Resposta4 = "Aconcágua";
        q33.Resposta5 = "Makalu";
        q33.Respostacorreta = 3;
        q33.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q33);

        // Pergunta 34
        var q34 = new Questao();
        q34.Nivelresposta = 4;
        q34.Pergunta = "Qual a minha atividade favorita no fim de semana?";
        q34.Resposta1 = "Assistir filmes";
        q34.Resposta2 = "Sair com amigos";
        q34.Resposta3 = "Ler";
        q34.Resposta4 = "Fazer compras";
        q34.Resposta5 = "Descansar";
        q34.Respostacorreta = 2;
        q34.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q34);

        // Pergunta 35
        var q35 = new Questao();
        q35.Nivelresposta = 4;
        q35.Pergunta = "Qual a minha série de livros favorita?";
        q35.Resposta1 = "Harry Potter";
        q35.Resposta2 = "O Senhor dos Anéis";
        q35.Resposta3 = "As Crônicas de Nárnia";
        q35.Resposta4 = "Percy Jackson";
        q35.Resposta5 = "Sherlock Holmes";
        q35.Respostacorreta = 1;
        q35.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q35);

        // Pergunta 36
        var q36 = new Questao();
        q36.Nivelresposta = 4;
        q36.Pergunta = "Qual a minha País que gostaria de visitar?";
        q36.Resposta1 = "México";
        q36.Resposta2 = "Estados Unidos";
        q36.Resposta3 = "Alemanha";
        q36.Resposta4 = "Japão";
        q36.Resposta5 = "Nigéria";
        q36.Respostacorreta = 1;
        q36.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q36);

        // Pergunta 37
        var q37 = new Questao();
        q37.Nivelresposta = 4;
        q37.Pergunta = "Qual meu filme de animação favorito?";
        q37.Resposta1 = "Toy Story";
        q37.Resposta2 = "Procurando Nemo";
        q37.Resposta3 = "Frozen";
        q37.Resposta4 = "Os Incríveis";
        q37.Resposta5 = "Shrek";
        q37.Respostacorreta = 5;
        q37.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q37);

        // Pergunta 38
        var q38 = new Questao();
        q38.Nivelresposta = 4;
        q38.Pergunta = "Qual meu tipo de comida favorita?";
        q38.Resposta1 = "Italiana";
        q38.Resposta2 = "Chinesa";
        q38.Resposta3 = "Japonesa";
        q38.Resposta4 = "Mexicana";
        q38.Resposta5 = "Brasileira";
        q38.Respostacorreta = 3;
        q38.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q38);

        // Pergunta 39
        var q39 = new Questao();
        q39.Nivelresposta = 4;
        q39.Pergunta = "Qual meu gênero de música favorito?";
        q39.Resposta1 = "Rock";
        q39.Resposta2 = "Pop";
        q39.Resposta3 = "Sertanejo";
        q39.Resposta4 = "MPB";
        q39.Resposta5 = "Clássica";
        q39.Respostacorreta = 3;
        q39.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q39);

        // Pergunta 40
        var q40 = new Questao();
        q40.Nivelresposta = 4;
        q40.Pergunta = "Qual meu filme de super-herói favorito?";
        q40.Resposta1 = "Os Vingadores";
        q40.Resposta2 = "Batman: O Cavaleiro das Trevas";
        q40.Resposta3 = "Spider-Man";
        q40.Resposta4 = "Deadpool";
        q40.Resposta5 = "Wonder Woman";
        q40.Respostacorreta = 2;
        q40.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q40);

        // Pergunta 41
        var q41 = new Questao();
        q41.Nivelresposta = 5;
        q41.Pergunta = "Qual é o maior mamífero do mundo?";
        q41.Resposta1 = "Elefante";
        q41.Resposta2 = "Baleia-azul";
        q41.Resposta3 = "Girafa";
        q41.Resposta4 = "Hipopótamo";
        q41.Resposta5 = "Avestruz";
        q41.Respostacorreta = 2;
        q41.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q41);

        // Pergunta 42
        var q42 = new Questao();
        q42.Nivelresposta = 5;
        q42.Pergunta = "Qual é a capital da Rússia?";
        q42.Resposta1 = "São Petersburgo";
        q42.Resposta2 = "Moscovo";
        q42.Resposta3 = "Kiev";
        q42.Resposta4 = "Vilnius";
        q42.Resposta5 = "Minsk";
        q42.Respostacorreta = 2;
        q42.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q42);

        // Pergunta 43
        var q43 = new Questao();
        q43.Nivelresposta = 5;
        q43.Pergunta = "Qual é o maior continente do mundo?";
        q43.Resposta1 = "África";
        q43.Resposta2 = "América do Norte";
        q43.Resposta3 = "Ásia";
        q43.Resposta4 = "Europa";
        q43.Resposta5 = "Oceania";
        q43.Respostacorreta = 3;
        q43.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q43);

        // Pergunta 44
        var q44 = new Questao();
        q44.Nivelresposta = 5;
        q44.Pergunta = "Qual meu animal selvagem favorito?";
        q44.Resposta1 = "Leão";
        q44.Resposta2 = "Tigre";
        q44.Resposta3 = "Elefante";
        q44.Resposta4 = "Urso";
        q44.Resposta5 = "Lobo";
        q44.Respostacorreta = 5;
        q44.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q44);

        // Pergunta 45
        var q45 = new Questao();
        q45.Nivelresposta = 5;
        q45.Pergunta = "Qual é a capital do Egito?";
        q45.Resposta1 = "Cairo";
        q45.Resposta2 = "Tunis";
        q45.Resposta3 = "Algérie";
        q45.Resposta4 = "Beirute";
        q45.Resposta5 = "Riad";
        q45.Respostacorreta = 1;
        q45.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q45);

        // Pergunta 46
        var q46 = new Questao();
        q46.Nivelresposta = 5;
        q46.Pergunta = "Em que ano começou a Primeira Guerra Mundial?";
        q46.Resposta1 = "1914";
        q46.Resposta2 = "1918";
        q46.Resposta3 = "1939";
        q46.Resposta4 = "1945";
        q46.Resposta5 = "1920";
        q46.Respostacorreta = 1;
        q46.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q46);

        // Pergunta 47
        var q47 = new Questao();
        q47.Nivelresposta = 5;
        q47.Pergunta = "Qual meu estilo de arte favorito?";
        q47.Resposta1 = "Impressionismo";
        q47.Resposta2 = "Surrealismo";
        q47.Resposta3 = "Abstrato";
        q47.Resposta4 = "Clássico";
        q47.Resposta5 = "Moderno";
        q47.Respostacorreta = 3;
        q47.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q47);

        // Pergunta 48
        var q48 = new Questao();
        q48.Nivelresposta = 5;
        q48.Pergunta = "Qual é o gás mais abundante na atmosfera da Terra?";
        q48.Resposta1 = "Oxigênio";
        q48.Resposta2 = "Nitrogênio";
        q48.Resposta3 = "Dióxido de carbono";
        q48.Resposta4 = "Hélio";
        q48.Resposta5 = "Hidrogênio";
        q48.Respostacorreta = 2;
        q48.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q48);

        // Pergunta 49
        var q49 = new Questao();
        q49.Nivelresposta = 5;
        q49.Pergunta = "Qual é o órgão responsável pela circulação sanguínea?";
        q49.Resposta1 = "Fígado";
        q49.Resposta2 = "Coração";
        q49.Resposta3 = "Rim";
        q49.Resposta4 = "Pulmão";
        q49.Resposta5 = "Pâncreas";
        q49.Respostacorreta = 2;
        q49.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q49);

        // Pergunta 50
        var q50 = new Questao();
        q50.Nivelresposta = 5;
        q50.Pergunta = "Qual minha estação do ano menos favorita?";
        q50.Resposta1 = "Inverno";
        q50.Resposta2 = "Verão";
        q50.Resposta3 = "Outono";
        q50.Resposta4 = "Primavera";
        q50.Resposta5 = "Nenhuma";
        q50.Respostacorreta = 1;
        q50.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q50);

        var q51 = new Questao();
        q51.Nivelresposta = 6;
        q51.Pergunta = "Qual é o maior rio do mundo?";
        q51.Resposta1 = "Rio Amazonas";
        q51.Resposta2 = "Rio Nilo";
        q51.Resposta3 = "Rio Yangtze";
        q51.Resposta4 = "Rio Mississipi";
        q51.Resposta5 = "Rio Mekong";
        q51.Respostacorreta = 1;
        q51.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q51);

        // Pergunta 52
        var q52 = new Questao();
        q52.Nivelresposta = 6;
        q52.Pergunta = "Qual minha cor preferida de carro?";
        q52.Resposta1 = "Vermelho";
        q52.Resposta2 = "Preto";
        q52.Resposta3 = "Branco";
        q52.Resposta4 = "Azul";
        q52.Resposta5 = "Verde";
        q52.Respostacorreta = 2;
        q52.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q52);

        // Pergunta 53
        var q53 = new Questao();
        q53.Nivelresposta = 6;
        q53.Pergunta = "Qual a capital da Espanha?";
        q53.Resposta1 = "Barcelona";
        q53.Resposta2 = "Valência";
        q53.Resposta3 = "Madrid";
        q53.Resposta4 = "Sevilha";
        q53.Resposta5 = "Bilbao";
        q53.Respostacorreta = 3;
        q53.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q53);

        // Pergunta 54
        var q54 = new Questao();
        q54.Nivelresposta = 6;
        q54.Pergunta = "Qual meu estilo de vida?";
        q54.Resposta1 = "Aventureiro";
        q54.Resposta2 = "Saudável";
        q54.Resposta3 = "Sustentável";
        q54.Resposta4 = "Minimalista";
        q54.Resposta5 = "Urbano";
        q54.Respostacorreta = 2;
        q54.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q54);

        // Pergunta 55
        var q55 = new Questao();
        q55.Nivelresposta = 6;
        q55.Pergunta = "Qual meu sabor de sorvete favorito?";
        q55.Resposta1 = "Chocolate";
        q55.Resposta2 = "Morango";
        q55.Resposta3 = "Baunilha";
        q55.Resposta4 = "Limão";
        q55.Resposta5 = "Pistache";
        q55.Respostacorreta = 2;
        q55.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q55);

        // Pergunta 56
        var q56 = new Questao();
        q56.Nivelresposta = 6;
        q56.Pergunta = "Qual é a capital da Grécia?";
        q56.Resposta1 = "Atenas";
        q56.Resposta2 = "Esparta";
        q56.Resposta3 = "Tessalônica";
        q56.Resposta4 = "Corinto";
        q56.Resposta5 = "Rodes";
        q56.Respostacorreta = 1;
        q56.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q56);
    
        // Pergunta 57
        var q57 = new Questao();
        q57.Nivelresposta = 6;
        q57.Pergunta = "Qual é o sistema que controla o corpo humano?";
        q57.Resposta1 = "Digestivo";
        q57.Resposta2 = "Circulatório";
        q57.Resposta3 = "Nervoso";
        q57.Resposta4 = "Respiratório";
        q57.Resposta5 = "Endócrino";
        q57.Respostacorreta = 3;
        q57.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q57);

        // Pergunta 58
        var q58 = new Questao();
        q58.Nivelresposta = 6;
        q58.Pergunta = "Qual meu gênero literário favorito?";
        q58.Resposta1 = "Ficção Científica";
        q58.Resposta2 = "Romance";
        q58.Resposta3 = "Fantasia";
        q58.Resposta4 = "Terror";
        q58.Resposta5 = "Biografia";
        q58.Respostacorreta = 4;
        q58.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q58);

        // Pergunta 59
        var q59 = new Questao();
        q59.Nivelresposta = 6;
        q59.Pergunta = "Qual é a capital da Índia?";
        q59.Resposta1 = "Nova Délhi";
        q59.Resposta2 = "Bombaim";
        q59.Resposta3 = "Calcutá";
        q59.Resposta4 = "Bangalore";
        q59.Resposta5 = "Chennai";
        q59.Respostacorreta = 1;
        q59.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q59);

        // Pergunta 60
        var q60 = new Questao();
        q60.Nivelresposta = 6;
        q60.Pergunta = "Qual é a capital de Portugal?";
        q60.Resposta1 = "Lisboa";
        q60.Resposta2 = "Porto";
        q60.Resposta3 = "Coimbra";
        q60.Resposta4 = "Braga";
        q60.Resposta5 = "Évora";
        q60.Respostacorreta = 1;
        q60.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q60);

        var q61 = new Questao();
        q61.Nivelresposta = 7;
        q61.Pergunta = "Qual é o planeta mais distante do sol?";
        q61.Resposta1 = "Netuno";
        q61.Resposta2 = "Plutão";
        q61.Resposta3 = "Urano";
        q61.Resposta4 = "Saturno";
        q61.Resposta5 = "Júpiter";
        q61.Respostacorreta = 1;
        q61.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q61);

        // Pergunta 2
        var q62 = new Questao();
        q62.Nivelresposta = 7;
        q62.Pergunta = "Qual é a capital da Suécia?";
        q62.Resposta1 = "Estocolmo";
        q62.Resposta2 = "Oslo";
        q62.Resposta3 = "Copenhague";
        q62.Resposta4 = "Helsinque";
        q62.Resposta5 = "Reykjavik";
        q62.Respostacorreta = 1;
        q62.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q62);

        // Pergunta 3
        var q63 = new Questao();
        q63.Nivelresposta = 7;
        q63.Pergunta = "Qual é a moeda do Reino Unido?";
        q63.Resposta1 = "Euro";
        q63.Resposta2 = "Libra Esterlina";
        q63.Resposta3 = "Dólar";
        q63.Resposta4 = "Franco";
        q63.Resposta5 = "Yen";
        q63.Respostacorreta = 2;
        q63.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q63);

        // Pergunta 4
        var q64 = new Questao();
        q64.Nivelresposta = 7;
        q64.Pergunta = "Qual é a capital da Turquia?";
        q64.Resposta1 = "Istambul";
        q64.Resposta2 = "Ankara";
        q64.Resposta3 = "Antália";
        q64.Resposta4 = "Izmir";
        q64.Resposta5 = "Bursa";
        q64.Respostacorreta = 2;
        q64.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q64);

        // Pergunta 5
        var q65 = new Questao();
        q65.Nivelresposta = 7;
        q65.Pergunta = "Qual é o autor de 'O Senhor dos Anéis'?";
        q65.Resposta1 = "George R.R. Martin";
        q65.Resposta2 = "J.R.R. Tolkien";
        q65.Resposta3 = "C.S. Lewis";
        q65.Resposta4 = "J.K. Rowling";
        q65.Resposta5 = "Philip Pullman";
        q65.Respostacorreta = 2;
        q65.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q65);

        // Pergunta 6
        var q66 = new Questao();
        q66.Nivelresposta = 7;
        q66.Pergunta = "Quem é o fundador da Microsoft?";
        q66.Resposta1 = "Steve Jobs";
        q66.Resposta2 = "Bill Gates";
        q66.Resposta3 = "Elon Musk";
        q66.Resposta4 = "Mark Zuckerberg";
        q66.Resposta5 = "Larry Page";
        q66.Respostacorreta = 2;
        q66.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q66);

        // Pergunta 7
        var q67 = new Questao();
        q67.Nivelresposta = 7;
        q67.Pergunta = "Qual minha banda favorita?";
        q67.Resposta1 = "Slipknot";
        q67.Resposta2 = "Beatles";
        q67.Resposta3 = "Nirvana";
        q67.Resposta4 = "Pink Floyd";
        q67.Resposta5 = "Metallica";
        q67.Respostacorreta = 1;
        q67.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q67);

        // Pergunta 8
        var q68 = new Questao();
        q68.Nivelresposta = 7;
        q68.Pergunta = "Qual é o símbolo químico do ouro?";
        q68.Resposta1 = "Ag";
        q68.Resposta2 = "Au";
        q68.Resposta3 = "Pb";
        q68.Resposta4 = "Fe";
        q68.Resposta5 = "Hg";
        q68.Respostacorreta = 2;
        q68.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q68);

        // Pergunta 9
        var q69 = new Questao();
        q69.Nivelresposta = 7;
        q69.Pergunta = "Qual é o maior animal aquático?";
        q69.Resposta1 = "Tubarão-branco";
        q69.Resposta2 = "Baleia-azul";
        q69.Resposta3 = "Orca";
        q69.Resposta4 = "Golfinho";
        q69.Resposta5 = "Foca";
        q69.Respostacorreta = 2;
        q69.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q69);

        // Pergunta 10
        var q70 = new Questao();
        q70.Nivelresposta = 7;
        q70.Pergunta = "Qual é a capital da Noruega?";
        q70.Resposta1 = "Oslo";
        q70.Resposta2 = "Estocolmo";
        q70.Resposta3 = "Copenhague";
        q70.Resposta4 = "Helsinque";
        q70.Resposta5 = "Reykjavik";
        q70.Respostacorreta = 1;
        q70.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q70);

        var q71 = new Questao();
        q71.Nivelresposta = 8;
        q71.Pergunta = "Qual é a moeda do Japão?";
        q71.Resposta1 = "Yuan";
        q71.Resposta2 = "Won";
        q71.Resposta3 = "Dólar";
        q71.Resposta4 = "Iene";
        q71.Resposta5 = "Rupia";
        q71.Respostacorreta = 4;
        q71.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q71);

        var q72 = new Questao();
        q72.Nivelresposta = 8;
        q72.Pergunta = "Qual meu time de futebol favorito?";
        q72.Resposta1 = "Flamengo";
        q72.Resposta2 = "São Paulo";
        q72.Resposta3 = "Palmeiras";
        q72.Resposta4 = "Corinthians";
        q72.Resposta5 = "Vasco";
        q72.Respostacorreta = 4;
        q72.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q72);

        var q73 = new Questao();
        q73.Nivelresposta = 8;
        q73.Pergunta = "Qual é o continente mais frio do mundo?";
        q73.Resposta1 = "Antártida";
        q73.Resposta2 = "África";
        q73.Resposta3 = "Ásia";
        q73.Resposta4 = "América do Sul";
        q73.Resposta5 = "Europa";
        q73.Respostacorreta = 1;
        q73.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q73);

        var q74 = new Questao();
        q74.Nivelresposta = 8;
        q74.Pergunta = "Qual é a capital da Bélgica?";
        q74.Resposta1 = "Bruxelas";
        q74.Resposta2 = "Antuérpia";
        q74.Resposta3 = "Bruges";
        q74.Resposta4 = "Ghent";
        q74.Resposta5 = "Liège";
        q74.Respostacorreta = 1;
        q74.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q74);

        var q75 = new Questao();
        q75.Nivelresposta = 8;
        q75.Pergunta = "Quem foi o primeiro homem a pisar na lua?";
        q75.Resposta1 = "Neil Armstrong";
        q75.Resposta2 = "Buzz Aldrin";
        q75.Resposta3 = "Yuri Gagarin";
        q75.Resposta4 = "John Glenn";
        q75.Resposta5 = "Alan Shepard";
        q75.Respostacorreta = 1;
        q75.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q75);

        var q76 = new Questao();
        q76.Nivelresposta = 8;
        q76.Pergunta = "Qual é o símbolo químico do carbono?";
        q76.Resposta1 = "C";
        q76.Resposta2 = "Ca";
        q76.Resposta3 = "Co";
        q76.Resposta4 = "Cu";
        q76.Resposta5 = "Cr";
        q76.Respostacorreta = 1;
        q76.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q76);

        var q77 = new Questao();
        q77.Nivelresposta = 8;
        q77.Pergunta = "Qual é o maior oceano do mundo?";
        q77.Resposta1 = "Oceano Atlântico";
        q77.Resposta2 = "Oceano Índico";
        q77.Resposta3 = "Oceano Pacífico";
        q77.Resposta4 = "Oceano Ártico";
        q77.Resposta5 = "Oceano Antártico";
        q77.Respostacorreta = 3;
        q77.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q77);

        // Pergunta 18
        var q78 = new Questao();
        q78.Nivelresposta = 8;
        q78.Pergunta = "Qual é o continente onde se encontra o Egito?";
        q78.Resposta1 = "África";
        q78.Resposta2 = "Ásia";
        q78.Resposta3 = "América";
        q78.Resposta4 = "Europa";
        q78.Resposta5 = "Oceania";
        q78.Respostacorreta = 1;

        q78.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q78);

        // Pergunta 19
        var q79 = new Questao();
        q79.Nivelresposta = 8;
        q79.Pergunta = "Qual é o órgão responsável pela produção de insulina?";
        q79.Resposta1 = "Fígado";
        q79.Resposta2 = "Pâncreas";
        q79.Resposta3 = "Rim";
        q79.Resposta4 = "Coração";
        q79.Resposta5 = "Pulmão";
        q79.Respostacorreta = 2;
        q79.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q79);

        // Pergunta 20
        var q80 = new Questao();
        q80.Nivelresposta = 8;
        q80.Pergunta = "Qual é a maior ilha do mundo?";
        q80.Resposta1 = "Grã-Bretanha";
        q80.Resposta2 = "Groenlândia";
        q80.Resposta3 = "Nova Guiné";
        q80.Resposta4 = "Borneo";
        q80.Resposta5 = "Madagascar";
        q80.Respostacorreta = 2;
        q80.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q80);

        // Pergunta 21
        var q81 = new Questao();
        q81.Nivelresposta = 9;
        q81.Pergunta = "Quem foi o primeiro presidente do Brasil?";
        q81.Resposta1 = "Deodoro da Fonseca";
        q81.Resposta2 = "Getúlio Vargas";
        q81.Resposta3 = "Juscelino Kubitschek";
        q81.Resposta4 = "Fernando Henrique Cardoso";
        q81.Resposta5 = "Lula";
        q81.Respostacorreta = 1;
        q81.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q81);

        // Pergunta 22
        var q82 = new Questao();
        q82.Nivelresposta = 9;
        q82.Pergunta = "Qual meu instrumento musical favorito?";
        q82.Resposta1 = "Guitarra";
        q82.Resposta2 = "Piano";
        q82.Resposta3 = "Bateria";
        q82.Resposta4 = "Violão";
        q82.Resposta5 = "Saxofone";
        q82.Respostacorreta = 1;
        q82.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q82);

        var q83 = new Questao();
        q83.Nivelresposta = 9;
        q83.Pergunta = "Qual é a capital do Japão?";
        q83.Resposta1 = "Tóquio";
        q83.Resposta2 = "Osaka";
        q83.Resposta3 = "Kyoto";
        q83.Resposta4 = "Hiroshima";
        q83.Resposta5 = "Nagasaki";
        q83.Respostacorreta = 1;
        q83.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q83);

        var q84 = new Questao();
        q84.Nivelresposta = 9;
        q84.Pergunta = "Qual é a moeda da Rússia?";
        q84.Resposta1 = "Rublo";
        q84.Resposta2 = "Dólar";
        q84.Resposta3 = "Euro";
        q84.Resposta4 = "Yuan";
        q84.Resposta5 = "Coroa";
        q84.Respostacorreta = 1;

        q84.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q84);

        var q85 = new Questao();
        q85.Nivelresposta = 9;
        q85.Pergunta = "Qual é a fórmula da glicose?";
        q85.Resposta1 = "C6H12O6";
        q85.Resposta2 = "C2H5OH";
        q85.Resposta3 = "H2O";
        q85.Resposta4 = "CO2";
        q85.Resposta5 = "NaCl";
        q85.Respostacorreta = 1;
        q85.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q85);

        var q86 = new Questao();
        q86.Nivelresposta = 9;
        q86.Pergunta = "Quem foi o autor de 'Dom Casmurro'?";
        q86.Resposta1 = "Machado de Assis";
        q86.Resposta2 = "José de Alencar";
        q86.Resposta3 = "Graciliano Ramos";
        q86.Resposta4 = "Jorge Amado";
        q86.Resposta5 = "Clarice Lispector";
        q86.Respostacorreta = 1;
        q86.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q86);

        var q87 = new Questao();
        q87.Nivelresposta = 9;
        q87.Pergunta = "Qual meu personagem de ficção favorito?";
        q87.Resposta1 = "Harry Potter";
        q87.Resposta2 = "Frodo Bolseiro";
        q87.Resposta3 = "Sherlock Holmes";
        q87.Resposta4 = "Katniss Everdeen";
        q87.Resposta5 = "Walter White";
        q87.Respostacorreta = 1;
        q87.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q87);

        var q88 = new Questao();
        q88.Nivelresposta = 9;
        q88.Pergunta = "Quem descobriu a América?";
        q88.Resposta1 = "Fernando de Magalhães";
        q88.Resposta2 = "Cristóvão Colombo";
        q88.Resposta3 = "Vasco da Gama";
        q88.Resposta4 = "Pedro Álvares Cabral";
        q88.Resposta5 = "James Cook";
        q88.Respostacorreta = 2;
        q88.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q88);

        var q89 = new Questao();
        q89.Nivelresposta = 9;
        q89.Pergunta = "Qual a minha franquia de filmes favorita?";
        q89.Resposta1 = "Barbie";
        q89.Resposta2 = "Velozes e Furiosos";
        q89.Resposta3 = "Vingadores";
        q89.Resposta4 = "Maze Runner";
        q89.Resposta5 = "Jogos Vorazes";
        q89.Respostacorreta = 2;
        q89.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q89);

        var q90 = new Questao();
        q90.Nivelresposta = 9;
        q90.Pergunta = "Qual meu continente favorito para visitar?";
        q90.Resposta1 = "Ásia";
        q90.Resposta2 = "Europa";
        q90.Resposta3 = "África";
        q90.Resposta4 = "América";
        q90.Resposta5 = "Oceania";
        q90.Respostacorreta = 2;
        q90.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q90);

        var q91 = new Questao();
        q91.Nivelresposta = 10;
        q91.Pergunta = "Qual meu tipo de café favorito?";
        q91.Resposta1 = "Espresso";
        q91.Resposta2 = "Cappuccino";
        q91.Resposta3 = "Latte";
        q91.Resposta4 = "Americano";
        q91.Resposta5 = "Frappuccino";
        q91.Respostacorreta = 2;
        q91.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q91);

        var q92 = new Questao();
        q92.Nivelresposta = 10;
        q92.Pergunta = "Qual é o continente mais populoso?";
        q92.Resposta1 = "África";
        q92.Resposta2 = "América";
        q92.Resposta3 = "Europa";
        q92.Resposta4 = "Ásia";
        q92.Resposta5 = "Oceania";
        q92.Respostacorreta = 4;
        q92.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q92);

        var q93 = new Questao();
        q93.Nivelresposta = 10;
        q93.Pergunta = "Qual meu jogo de cartas favorito?";
        q93.Resposta1 = "Pôquer";
        q93.Resposta2 = "Buraco";
        q93.Resposta3 = "Truco";
        q93.Resposta4 = "UNO";
        q93.Resposta5 = "Magic: The Gathering";
        q93.Respostacorreta = 3;
        q93.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q93);

        var q94 = new Questao();
        q94.Nivelresposta = 10;
        q94.Pergunta = "Qual minha flor favorita?";
        q94.Resposta1 = "Rosa";
        q94.Resposta2 = "Girassol";
        q94.Resposta3 = "Tulipa";
        q94.Resposta4 = "Orquídea";
        q94.Resposta5 = "Lírio";
        q94.Respostacorreta = 2;
        q94.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q94);

        var q95 = new Questao();
        q95.Nivelresposta = 10;
        q95.Pergunta = "Qual é o elemento químico com o símbolo H?";
        q95.Resposta1 = "Hélio";
        q95.Resposta2 = "Hidrogênio";
        q95.Resposta3 = "Mercúrio";
        q95.Resposta4 = "Lítio";
        q95.Resposta5 = "Cálcio";
        q95.Respostacorreta = 2;
        q95.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q95);

        var q96 = new Questao();
        q96.Nivelresposta = 10;
        q96.Pergunta = "Qual meu tema favorito de festa?";
        q96.Resposta1 = "Festa à fantasia";
        q96.Resposta2 = "Aniversário";
        q96.Resposta3 = "Natal";
        q96.Resposta4 = "Ano Novo";
        q96.Resposta5 = "Halloween";
        q96.Respostacorreta = 5;
        q96.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q96);

        var q97 = new Questao();
        q97.Nivelresposta = 10;
        q97.Pergunta = "Qual é o maior país do mundo?";
        q97.Resposta1 = "Canadá";
        q97.Resposta2 = "Rússia";
        q97.Resposta3 = "Estados Unidos";
        q97.Resposta4 = "China";
        q97.Resposta5 = "Brasil";
        q97.Respostacorreta = 2;
        q97.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q97);

        var q98 = new Questao();
        q98.Nivelresposta = 10;
        q98.Pergunta = "Qual meu doce favorito de infância?";
        q98.Resposta1 = "Pipoca doce";
        q98.Resposta2 = "Bala";
        q98.Resposta3 = "Chocolate";
        q98.Resposta4 = "Gelatina";
        q98.Resposta5 = "Sorvete";
        q98.Respostacorreta = 1;
        q98.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q98);

        var q99 = new Questao();
        q99.Nivelresposta = 10;
        q99.Pergunta = "Qual é a língua mais falada no mundo?";
        q99.Resposta1 = "Espanhol";
        q99.Resposta2 = "Inglês";
        q99.Resposta3 = "Mandarim";
        q99.Resposta4 = "Francês";
        q99.Resposta5 = "Árabe";
        q99.Respostacorreta = 3;
        q99.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q99);

        var q100 = new Questao();
        q100.Nivelresposta = 10;
        q100.Pergunta = "Qual é o principal tipo de rocha encontrada na crosta terrestre?";
        q100.Resposta1 = "Ígnea";
        q100.Resposta2 = "Sedimentar";
        q100.Resposta3 = "Metamórfica";
        q100.Resposta4 = "Cálcica";
        q100.Resposta5 = "Granítica";
        q100.Respostacorreta = 1;
        q100.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q100);
     }  
       public void ProximaQuestao(){
        var numRandom = Random.Shared.Next(0, listaQuestoes.Count -1);

        while(listaQuestoesRespondidas.Contains(numRandom)){
            numRandom = Random.Shared.Next(0,listaQuestoes.Count - 1);
        } 

        listaQuestoesRespondidas.Add(numRandom);
        questaoCorrente = listaQuestoes[numRandom];
        questaoCorrente.Desenhar();
    }
    
    

    public async void VerificaCorreta (int RR)
    {
        if (questaoCorrente.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuação(NivelResposta);
            NivelResposta++;
            ProximaQuestao();
            labelNivel.Text = "Nível: " + NivelResposta.ToString();
            labelPontuacao.Text = "Pontuação: " + Pontuacao.ToString();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
            Inicializar();
        }
    }
    public void AdicionaPontuação(int RR)
            {
                if (RR==1)
                {
                    Pontuacao= 1000;
                }
                else if (RR==2)
                {
                    Pontuacao= 2000;
                }
                else if (RR==3)
                {
                    Pontuacao= 5000;
                }
                else if (RR==4)
                {
                    Pontuacao= 10000;
                }
                else if (RR==5)
                {
                    Pontuacao= 20000;
                }
                else if (RR==6)
                {
                    Pontuacao= 50000;
                }
                else if (RR==7)
                {
                    Pontuacao= 100000;
                }
                else if (RR==8)
                {
                    Pontuacao= 500000;
                }
                else if (RR==9)
                {
                    Pontuacao= 500000;
                }
                else
                {
                    Pontuacao= 1000000;
                }
            }
    }