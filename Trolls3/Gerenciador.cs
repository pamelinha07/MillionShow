namespace Trolls3;

public class Gerenciador
{

    List <Questao> listaQuestoes = new List<Questao> ();
    List <int> listaQuestoesRespondidas = new List<int> ();
    Questao questaoCorrente;
    public Gerenciador( Label labelPergunta, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05){
        CriarQuestoes(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }
     void CriarQuestoes (Label labelPergunta, Button buttonResp01, Button buttonResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
     {
        var q1 = new Questao();
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
        q2.Pergunta = "Qual a minha fruta favorita?";
        q2.Resposta1 = "Banana";
        q2.Resposta2 = "Manga";
        q2.Resposta3 = "Maçã";
        q2.Resposta4 = "Pera";
        q2.Resposta5 = "Uva";
        q2.Respostacorreta = 1;
        q2.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q2);

        // Pergunta 3
        var q3 = new Questao();
        q3.Pergunta = "Qual o meu filme favorito?";
        q3.Resposta1 = "O Senhor dos Anéis";
        q3.Resposta2 = "Star Wars";
        q3.Resposta3 = "A Matrix";
        q3.Resposta4 = "Titanic";
        q3.Resposta5 = "O Poderoso Chefão";
        q3.Respostacorreta = 1;
        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q3);

        // Pergunta 4
        var q4 = new Questao();
        q4.Pergunta = "Qual a cor do meu carro?";
        q4.Resposta1 = "Vermelho";
        q4.Resposta2 = "Preto";
        q4.Resposta3 = "Branco";
        q4.Resposta4 = "Azul";
        q4.Resposta5 = "Prata";
        q4.Respostacorreta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q4);

        // Pergunta 5
        var q5 = new Questao();
        q5.Pergunta = "Qual é o meu esporte favorito?";
        q5.Resposta1 = "Futebol";
        q5.Resposta2 = "Basquete";
        q5.Resposta3 = "Natação";
        q5.Resposta4 = "Vôlei";
        q5.Resposta5 = "Tênis";
        q5.Respostacorreta = 1;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q5);

        // Pergunta 6
        var q6 = new Questao();
        q6.Pergunta = "Qual a minha série favorita?";
        q6.Resposta1 = "Breaking Bad";
        q6.Resposta2 = "Game of Thrones";
        q6.Resposta3 = "Friends";
        q6.Resposta4 = "Stranger Things";
        q6.Resposta5 = "The Office";
        q6.Respostacorreta = 2;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q6);

        // Pergunta 7
        var q7 = new Questao();
        q7.Pergunta = "Qual o meu livro favorito?";
        q7.Resposta1 = "1984";
        q7.Resposta2 = "O Senhor dos Anéis";
        q7.Resposta3 = "Harry Potter";
        q7.Resposta4 = "Dom Casmurro";
        q7.Resposta5 = "O Pequeno Príncipe";
        q7.Respostacorreta = 5;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q7);

        // Pergunta 8
        var q8 = new Questao();
        q8.Pergunta = "Qual a minha comida favorita?";
        q8.Resposta1 = "Pizza";
        q8.Resposta2 = "Sushi";
        q8.Resposta3 = "Feijoada";
        q8.Resposta4 = "Churrasco";
        q8.Resposta5 = "Lasanha";
        q8.Respostacorreta = 4;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q8);

        // Pergunta 9
        var q9 = new Questao();
        q9.Pergunta = "Qual o meu país favorito para viajar?";
        q9.Resposta1 = "Japão";
        q9.Resposta2 = "França";
        q9.Resposta3 = "Brasil";
        q9.Resposta4 = "Austrália";
        q9.Resposta5 = "Canadá";
        q9.Respostacorreta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q9);

        // Pergunta 10
        var q10 = new Questao();
        q10.Pergunta = "Qual o meu animal favorito?";
        q10.Resposta1 = "Gato";
        q10.Resposta2 = "Cachorro";
        q10.Resposta3 = "Pássaro";
        q10.Resposta4 = "Peixe";
        q10.Resposta5 = "Coelho";
        q10.Respostacorreta = 2;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q10);

        // Continue até a pergunta 100...

        // Pergunta 11
        var q11 = new Questao();
        q11.Pergunta = "Qual a minha cor favorita?";
        q11.Resposta1 = "Azul";
        q11.Resposta2 = "Verde";
        q11.Resposta3 = "Vermelho";
        q11.Resposta4 = "Amarelo";
        q11.Resposta5 = "Preto";
        q11.Respostacorreta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q11);

        // Pergunta 12
        var q12 = new Questao();
        q12.Pergunta = "Qual o meu instrumento musical favorito?";
        q12.Resposta1 = "Guitarra";
        q12.Resposta2 = "Piano";
        q12.Resposta3 = "Bateria";
        q12.Resposta4 = "Violão";
        q12.Resposta5 = "Saxofone";
        q12.Respostacorreta = 1;
        q12.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q12);

        // Pergunta 13
        var q13 = new Questao();
        q13.Pergunta = "Qual o meu hobby favorito?";
        q13.Resposta1 = "Cozinhar";
        q13.Resposta2 = "Viajar";
        q13.Resposta3 = "Ler";
        q13.Resposta4 = "Correr";
        q13.Resposta5 = "Jogar videogame";
        q13.Respostacorreta = 2;
        q13.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q13);

        // Pergunta 14
        var q14 = new Questao();
        q14.Pergunta = "Qual a minha bebida favorita?";
        q14.Resposta1 = "Água";
        q14.Resposta2 = "Cerveja";
        q14.Resposta3 = "Refrigerante";
        q14.Resposta4 = "Suco";
        q14.Resposta5 = "Vinho";
        q14.Respostacorreta = 4;
        q14.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q14);

        // Pergunta 15
        var q15 = new Questao();
        q15.Pergunta = "Qual o meu destino de férias favorito?";
        q15.Resposta1 = "Praia";
        q15.Resposta2 = "Montanha";
        q15.Resposta3 = "Cidade";
        q15.Resposta4 = "Campo";
        q15.Resposta5 = "Estrangeiro";
        q15.Respostacorreta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q15);

        // Pergunta 16
        var q16 = new Questao();
        q16.Pergunta = "Qual a minha estação do ano favorita?";
        q16.Resposta1 = "Verão";
        q16.Resposta2 = "Inverno";
        q16.Resposta3 = "Primavera";
        q16.Resposta4 = "Outono";
        q16.Resposta5 = "Nenhuma";
        q16.Respostacorreta = 1;
        q16.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q16);

        // Pergunta 17
        var q17 = new Questao();
        q17.Pergunta = "Qual o meu super-herói favorito?";
        q17.Resposta1 = "Superman";
        q17.Resposta2 = "Batman";
        q17.Resposta3 = "Spider-Man";
        q17.Resposta4 = "Iron Man";
        q17.Resposta5 = "Thor";
        q17.Respostacorreta = 2;
        q17.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q17);

        // Pergunta 18
        var q18 = new Questao();
        q18.Pergunta = "Qual o meu tipo de música favorita?";
        q18.Resposta1 = "Rock";
        q18.Resposta2 = "Pop";
        q18.Resposta3 = "Jazz";
        q18.Resposta4 = "Clássica";
        q18.Resposta5 = "Sertanejo";
        q18.Respostacorreta = 1;
        q18.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q18);

        // Pergunta 19
        var q19 = new Questao();
        q19.Pergunta = "Qual a minha sobremesa favorita?";
        q19.Resposta1 = "Bolo";
        q19.Resposta2 = "Sorvete";
        q19.Resposta3 = "Pudim";
        q19.Resposta4 = "Torta";
        q19.Resposta5 = "Gelatina";
        q19.Respostacorreta = 2;
        q19.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q19);

        // Pergunta 20
        var q20 = new Questao();
        q20.Pergunta = "Qual a minha profissão dos sonhos?";
        q20.Resposta1 = "Médico";
        q20.Resposta2 = "Engenheiro";
        q20.Resposta3 = "Artista";
        q20.Resposta4 = "Professor";
        q20.Resposta5 = "Cientista";
        q20.Respostacorreta = 3;
        q20.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q20);

        // Continue até 100...

        // Pergunta 21
        var q21 = new Questao();
        q21.Pergunta = "Qual o meu estilo de roupa favorito?";
        q21.Resposta1 = "Casual";
        q21.Resposta2 = "Formal";
        q21.Resposta3 = "Esportivo";
        q21.Resposta4 = "Vintage";
        q21.Resposta5 = "Urbano";
        q21.Respostacorreta = 1;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q21);

        // Pergunta 22
        var q22 = new Questao();
        q22.Pergunta = "Qual o meu passatempo preferido?";
        q22.Resposta1 = "Desenhar";
        q22.Resposta2 = "Fotografar";
        q22.Resposta3 = "Escrever";
        q22.Resposta4 = "Jogar";
        q22.Resposta5 = "Cozinhar";
        q22.Respostacorreta = 2;
        q22.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q22);

        // Pergunta 23
        var q23 = new Questao();
        q23.Pergunta = "Qual a minha cidade natal?";
        q23.Resposta1 = "São Paulo";
        q23.Resposta2 = "Rio de Janeiro";
        q23.Resposta3 = "Belo Horizonte";
        q23.Resposta4 = "Curitiba";
        q23.Resposta5 = "Salvador";
        q23.Respostacorreta = 1;
        q23.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q23);

        // Pergunta 24
        var q24 = new Questao();
        q24.Pergunta = "Qual o meu jogo de tabuleiro favorito?";
        q24.Resposta1 = "Banco Imobiliário";
        q24.Resposta2 = "War";
        q24.Resposta3 = "Detetive";
        q24.Resposta4 = "Xadrez";
        q24.Resposta5 = "Jogo da Vida";
        q24.Respostacorreta = 2;
        q24.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q24);

        // Pergunta 25
        var q25 = new Questao();
        q25.Pergunta = "Qual a minha série animada favorita?";
        q25.Resposta1 = "Os Simpsons";
        q25.Resposta2 = "Rick and Morty";
        q25.Resposta3 = "Avatar: A Lenda de Aang";
        q25.Resposta4 = "Bob Esponja";
        q25.Resposta5 = "Futurama";
        q25.Respostacorreta = 3;
        q25.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q25);

        // Pergunta 26
        var q26 = new Questao();
        q26.Pergunta = "Qual o meu esporte olímpico favorito?";
        q26.Resposta1 = "Natação";
        q26.Resposta2 = "Atletismo";
        q26.Resposta3 = "Ginástica";
        q26.Resposta4 = "Futebol";
        q26.Resposta5 = "Vôlei";
        q26.Respostacorreta = 1;
        q26.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q26);

        // Pergunta 27
        var q27 = new Questao();
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
        q28.Pergunta = "Qual o meu tipo de filme favorito?";
        q28.Resposta1 = "Ação";
        q28.Resposta2 = "Comédia";
        q28.Resposta3 = "Drama";
        q28.Resposta4 = "Terror";
        q28.Resposta5 = "Documentário";
        q28.Respostacorreta = 2;
        q28.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q28);

        // Pergunta 29
        var q29 = new Questao();
        q29.Pergunta = "Qual a minha sobremesa favorita?";
        q29.Resposta1 = "Torta de limão";
        q29.Resposta2 = "Pudim";
        q29.Resposta3 = "Bolo de chocolate";
        q29.Resposta4 = "Sorvete";
        q29.Resposta5 = "Cheesecake";
        q29.Respostacorreta = 3;
        q29.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q29);

        // Pergunta 30
        var q30 = new Questao();
        q30.Pergunta = "Qual a minha atividade preferida ao ar livre?";
        q30.Resposta1 = "Caminhada";
        q30.Resposta2 = "Ciclismo";
        q30.Resposta3 = "Piquenique";
        q30.Resposta4 = "Camping";
        q30.Resposta5 = "Natação";
        q30.Respostacorreta = 1;
        q30.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q30);

        // Continue até 100...

        // Pergunta 31
        var q31 = new Questao();
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
        q33.Pergunta = "Qual a minha tecnologia favorita?";
        q33.Resposta1 = "Computador";
        q33.Resposta2 = "Smartphone";
        q33.Resposta3 = "Tablet";
        q33.Resposta4 = "Relógio inteligente";
        q33.Resposta5 = "Console de videogame";
        q33.Respostacorreta = 2;
        q33.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q33);

        // Pergunta 34
        var q34 = new Questao();
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
        q36.Pergunta = "Qual a minha cidade que gostaria de visitar?";
        q36.Resposta1 = "Paris";
        q36.Resposta2 = "Nova York";
        q36.Resposta3 = "Londres";
        q36.Resposta4 = "Tóquio";
        q36.Resposta5 = "Roma";
        q36.Respostacorreta = 3;
        q36.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q36);

        // Pergunta 37
        var q37 = new Questao();
        q37.Pergunta = "Qual meu filme de animação favorito?";
        q37.Resposta1 = "Toy Story";
        q37.Resposta2 = "Procurando Nemo";
        q37.Resposta3 = "Frozen";
        q37.Resposta4 = "Os Incríveis";
        q37.Resposta5 = "Shrek";
        q37.Respostacorreta = 2;
        q37.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q37);

        // Pergunta 38
        var q38 = new Questao();
        q38.Pergunta = "Qual meu tipo de comida favorita?";
        q38.Resposta1 = "Italiana";
        q38.Resposta2 = "Chinesa";
        q38.Resposta3 = "Japonesa";
        q38.Resposta4 = "Mexicana";
        q38.Resposta5 = "Brasileira";
        q38.Respostacorreta = 1;
        q38.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q38);

        // Pergunta 39
        var q39 = new Questao();
        q39.Pergunta = "Qual meu gênero de música favorito?";
        q39.Resposta1 = "Rock";
        q39.Resposta2 = "Pop";
        q39.Resposta3 = "Sertanejo";
        q39.Resposta4 = "MPB";
        q39.Resposta5 = "Clássica";
        q39.Respostacorreta = 1;
        q39.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q39);

        // Pergunta 40
        var q40 = new Questao();
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
        q41.Pergunta = "Qual minha série de TV favorita?";
        q41.Resposta1 = "Friends";
        q41.Resposta2 = "Breaking Bad";
        q41.Resposta3 = "Game of Thrones";
        q41.Resposta4 = "The Office";
        q41.Resposta5 = "Stranger Things";
        q41.Respostacorreta = 3;
        q41.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q41);

        // Pergunta 42
        var q42 = new Questao();
        q42.Pergunta = "Qual meu aplicativo favorito?";
        q42.Resposta1 = "WhatsApp";
        q42.Resposta2 = "Instagram";
        q42.Resposta3 = "Spotify";
        q42.Resposta4 = "YouTube";
        q42.Resposta5 = "Twitter";
        q42.Respostacorreta = 3;
        q42.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q42);

        // Pergunta 43
        var q43 = new Questao();
        q43.Pergunta = "Qual minha rede social favorita?";
        q43.Resposta1 = "Facebook";
        q43.Resposta2 = "Instagram";
        q43.Resposta3 = "Twitter";
        q43.Resposta4 = "TikTok";
        q43.Resposta5 = "LinkedIn";
        q43.Respostacorreta = 2;
        q43.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q43);

        // Pergunta 44
        var q44 = new Questao();
        q44.Pergunta = "Qual meu animal selvagem favorito?";
        q44.Resposta1 = "Leão";
        q44.Resposta2 = "Tigre";
        q44.Resposta3 = "Elefante";
        q44.Resposta4 = "Urso";
        q44.Resposta5 = "Lobo";
        q44.Respostacorreta = 3;
        q44.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q44);

        // Pergunta 45
        var q45 = new Questao();
        q45.Pergunta = "Qual minha sobremesa favorita?";
        q45.Resposta1 = "Bolo de cenoura";
        q45.Resposta2 = "Pudim";
        q45.Resposta3 = "Torta de maçã";
        q45.Resposta4 = "Sorvete de chocolate";
        q45.Resposta5 = "Mousse de maracujá";
        q45.Respostacorreta = 1;
        q45.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q45);

        // Pergunta 46
        var q46 = new Questao();
        q46.Pergunta = "Qual meu tipo de férias preferido?";
        q46.Resposta1 = "Aventura";
        q46.Resposta2 = "Descanso";
        q46.Resposta3 = "Cultural";
        q46.Resposta4 = "Praia";
        q46.Resposta5 = "Esqui";
        q46.Respostacorreta = 4;
        q46.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q46);

        // Pergunta 47
        var q47 = new Questao();
        q47.Pergunta = "Qual meu estilo de arte favorito?";
        q47.Resposta1 = "Impressionismo";
        q47.Resposta2 = "Surrealismo";
        q47.Resposta3 = "Abstrato";
        q47.Resposta4 = "Clássico";
        q47.Resposta5 = "Moderno";
        q47.Respostacorreta = 2;
        q47.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q47);

        // Pergunta 48
        var q48 = new Questao();
        q48.Pergunta = "Qual meu hobby relacionado a tecnologia?";
        q48.Resposta1 = "Programação";
        q48.Resposta2 = "Design Gráfico";
        q48.Resposta3 = "Videomaker";
        q48.Resposta4 = "Fotografia";
        q48.Resposta5 = "Gamer";
        q48.Respostacorreta = 1;
        q48.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q48);

        // Pergunta 49
        var q49 = new Questao();
        q49.Pergunta = "Qual meu estilo musical menos favorito?";
        q49.Resposta1 = "Rock";
        q49.Resposta2 = "Pop";
        q49.Resposta3 = "Sertanejo";
        q49.Resposta4 = "Clássica";
        q49.Resposta5 = "Jazz";
        q49.Respostacorreta = 5;
        q49.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q49);

        // Pergunta 50
        var q50 = new Questao();
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
        q51.Pergunta = "Qual meu evento esportivo favorito?";
        q51.Resposta1 = "Copa do Mundo";
        q51.Resposta2 = "Olimpíadas";
        q51.Resposta3 = "Super Bowl";
        q51.Resposta4 = "NBA Finals";
        q51.Resposta5 = "Wimbledon";
        q51.Respostacorreta = 2;
        q51.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q51);

        // Pergunta 52
        var q52 = new Questao();
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
        q53.Pergunta = "Qual meu tipo de arte favorita?";
        q53.Resposta1 = "Pintura";
        q53.Resposta2 = "Escultura";
        q53.Resposta3 = "Fotografia";
        q53.Resposta4 = "Cinema";
        q53.Resposta5 = "Teatro";
        q53.Respostacorreta = 4;
        q53.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q53);

        // Pergunta 54
        var q54 = new Questao();
        q54.Pergunta = "Qual meu estilo de vida?";
        q54.Resposta1 = "Aventureiro";
        q54.Resposta2 = "Saudável";
        q54.Resposta3 = "Sustentável";
        q54.Resposta4 = "Minimalista";
        q54.Resposta5 = "Urbano";
        q54.Respostacorreta = 3;
        q54.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q54);

        // Pergunta 55
        var q55 = new Questao();
        q55.Pergunta = "Qual meu sabor de sorvete favorito?";
        q55.Resposta1 = "Chocolate";
        q55.Resposta2 = "Morango";
        q55.Resposta3 = "Baunilha";
        q55.Resposta4 = "Limão";
        q55.Resposta5 = "Pistache";
        q55.Respostacorreta = 1;
        q55.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q55);

        // Pergunta 56
        var q56 = new Questao();
        q56.Pergunta = "Qual meu destino de viagem dos sonhos?";
        q56.Resposta1 = "Maldivas";
        q56.Resposta2 = "Nova York";
        q56.Resposta3 = "Tóquio";
        q56.Resposta4 = "Dubai";
        q56.Resposta5 = "Paris";
        q56.Respostacorreta = 5;
        q56.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q56);

        // Pergunta 57
        var q57 = new Questao();
        q57.Pergunta = "Qual meu estilo de fotografia favorito?";
        q57.Resposta1 = "Retrato";
        q57.Resposta2 = "Paisagem";
        q57.Resposta3 = "Documental";
        q57.Resposta4 = "Fashion";
        q57.Resposta5 = "Aérea";
        q57.Respostacorreta = 2;
        q57.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q57);

        // Pergunta 58
        var q58 = new Questao();
        q58.Pergunta = "Qual meu gênero literário favorito?";
        q58.Resposta1 = "Ficção Científica";
        q58.Resposta2 = "Romance";
        q58.Resposta3 = "Fantasia";
        q58.Resposta4 = "Terror";
        q58.Resposta5 = "Biografia";
        q58.Respostacorreta = 3;
        q58.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q58);

        // Pergunta 59
        var q59 = new Questao();
        q59.Pergunta = "Qual meu programa de TV favorito?";
        q59.Resposta1 = "The Voice";
        q59.Resposta2 = "Big Brother Brasil";
        q59.Resposta3 = "MasterChef";
        q59.Resposta4 = "The Masked Singer";
        q59.Resposta5 = "Jogo da Sorte";
        q59.Respostacorreta = 3;
        q59.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q59);

        // Pergunta 60
        var q60 = new Questao();
        q60.Pergunta = "Qual meu talento escondido?";
        q60.Resposta1 = "Cantar";
        q60.Resposta2 = "Dançar";
        q60.Resposta3 = "Desenhar";
        q60.Resposta4 = "Cozer";
        q60.Resposta5 = "Escrever";
        q60.Respostacorreta = 3;
        q60.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q60);

        var q61 = new Questao();
        q61.Pergunta = "Qual o nome do meu cachorro?";
        q61.Resposta1 = "Trovao";
        q61.Resposta2 = "Fiote";
        q61.Resposta3 = "Jeredy";
        q61.Resposta4 = "Chico";
        q61.Resposta5 = "Bob";
        q61.Respostacorreta = 2;
        q61.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q61);

        // Pergunta 2
        var q62 = new Questao();
        q62.Pergunta = "Qual a minha cor favorita?";
        q62.Resposta1 = "Verde";
        q62.Resposta2 = "Azul";
        q62.Resposta3 = "Vermelho";
        q62.Resposta4 = "Amarelo";
        q62.Resposta5 = "Roxo";
        q62.Respostacorreta = 2;
        q62.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q62);

        // Pergunta 3
        var q63 = new Questao();
        q63.Pergunta = "Qual meu prato favorito?";
        q63.Resposta1 = "Pizza";
        q63.Resposta2 = "Sushi";
        q63.Resposta3 = "Feijoada";
        q63.Resposta4 = "Hambúrguer";
        q63.Resposta5 = "Lasanha";
        q63.Respostacorreta = 3;
        q63.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q63);

        // Pergunta 4
        var q64 = new Questao();
        q64.Pergunta = "Qual meu esporte favorito?";
        q64.Resposta1 = "Futebol";
        q64.Resposta2 = "Basquete";
        q64.Resposta3 = "Natação";
        q64.Resposta4 = "Vôlei";
        q64.Resposta5 = "Tênis";
        q64.Respostacorreta = 1;
        q64.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q64);

        // Pergunta 5
        var q65 = new Questao();
        q65.Pergunta = "Qual meu livro favorito?";
        q65.Resposta1 = "O Hobbit";
        q65.Resposta2 = "1984";
        q65.Resposta3 = "Dom Casmurro";
        q65.Resposta4 = "Harry Potter";
        q65.Resposta5 = "O Alquimista";
        q65.Respostacorreta = 4;
        q65.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q65);

        // Pergunta 6
        var q66 = new Questao();
        q66.Pergunta = "Qual meu filme favorito?";
        q66.Resposta1 = "O Senhor dos Anéis";
        q66.Resposta2 = "Matrix";
        q66.Resposta3 = "Titanic";
        q66.Resposta4 = "Star Wars";
        q66.Resposta5 = "Harry Potter";
        q66.Respostacorreta = 1;
        q66.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q66);

        // Pergunta 7
        var q67 = new Questao();
        q67.Pergunta = "Qual minha banda favorita?";
        q67.Resposta1 = "Queen";
        q67.Resposta2 = "Beatles";
        q67.Resposta3 = "Nirvana";
        q67.Resposta4 = "Pink Floyd";
        q67.Resposta5 = "Metallica";
        q67.Respostacorreta = 2;
        q67.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q67);

        // Pergunta 8
        var q68 = new Questao();
        q68.Pergunta = "Qual meu animal favorito?";
        q68.Resposta1 = "Cachorro";
        q68.Resposta2 = "Gato";
        q68.Resposta3 = "Pássaro";
        q68.Resposta4 = "Cavalo";
        q68.Resposta5 = "Peixe";
        q68.Respostacorreta = 1;
        q68.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q68);

        // Pergunta 9
        var q69 = new Questao();
        q69.Pergunta = "Qual meu hobby favorito?";
        q69.Resposta1 = "Cozinhar";
        q69.Resposta2 = "Jogar videogame";
        q69.Resposta3 = "Ler";
        q69.Resposta4 = "Caminhar";
        q69.Resposta5 = "Viajar";
        q69.Respostacorreta = 5;
        q69.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q69);

        // Pergunta 10
        var q70 = new Questao();
        q70.Pergunta = "Qual minha estação do ano favorita?";
        q70.Resposta1 = "Verão";
        q70.Resposta2 = "Inverno";
        q70.Resposta3 = "Primavera";
        q70.Resposta4 = "Outono";
        q70.Resposta5 = "Nenhuma";
        q70.Respostacorreta = 1;
        q70.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q70);

        // Pergunta 11
        var q71 = new Questao();
        q71.Pergunta = "Qual meu doce favorito?";
        q71.Resposta1 = "Chocolate";
        q71.Resposta2 = "Bolo";
        q71.Resposta3 = "Gelatina";
        q71.Resposta4 = "Pavê";
        q71.Resposta5 = "Docinho de leite condensado";
        q71.Respostacorreta = 1;
        q71.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q71);

        // Pergunta 12
        var q72 = new Questao();
        q72.Pergunta = "Qual meu time de futebol favorito?";
        q72.Resposta1 = "Flamengo";
        q72.Resposta2 = "São Paulo";
        q72.Resposta3 = "Palmeiras";
        q72.Resposta4 = "Corinthians";
        q72.Resposta5 = "Vasco";
        q72.Respostacorreta = 1;
        q72.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q72);

        // Pergunta 13
        var q73 = new Questao();
        q73.Pergunta = "Qual meu filme de animação favorito?";
        q73.Resposta1 = "O Rei Leão";
        q73.Resposta2 = "Toy Story";
        q73.Resposta3 = "Procurando Nemo";
        q73.Resposta4 = "Frozen";
        q73.Resposta5 = "Shrek";
        q73.Respostacorreta = 1;
        q73.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q73);

        // Pergunta 14
        var q74 = new Questao();
        q74.Pergunta = "Qual meu destino de férias favorito?";
        q74.Resposta1 = "Praia";
        q74.Resposta2 = "Montanha";
        q74.Resposta3 = "Cidade histórica";
        q74.Resposta4 = "Acampamento";
        q74.Resposta5 = "Cruzeiro";
        q74.Respostacorreta = 1;
        q74.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q74);

        // Pergunta 15
        var q75 = new Questao();
        q75.Pergunta = "Qual meu tipo de música favorita?";
        q75.Resposta1 = "Rock";
        q75.Resposta2 = "Pop";
        q75.Resposta3 = "Sertanejo";
        q75.Resposta4 = "Clássica";
        q75.Resposta5 = "Jazz";
        q75.Respostacorreta = 1;
        q75.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q75);

        // Pergunta 16
        var q76 = new Questao();
        q76.Pergunta = "Qual meu autor favorito?";
        q76.Resposta1 = "Machado de Assis";
        q76.Resposta2 = "J.K. Rowling";
        q76.Resposta3 = "George Orwell";
        q76.Resposta4 = "Stephen King";
        q76.Resposta5 = "Ernest Hemingway";
        q76.Respostacorreta = 2;
        q76.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q76);

        // Pergunta 17
        var q77 = new Questao();
        q77.Pergunta = "Qual minha série favorita?";
        q77.Resposta1 = "Friends";
        q77.Resposta2 = "Breaking Bad";
        q77.Resposta3 = "Game of Thrones";
        q77.Resposta4 = "Stranger Things";
        q77.Resposta5 = "The Office";
        q77.Respostacorreta = 3;
        q77.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q77);

        // Pergunta 18
        var q78 = new Questao();
        q78.Pergunta = "Qual meu jogo de tabuleiro favorito?";
        q78.Resposta1 = "Monopoly";
        q78.Resposta2 = "Banco Imobiliário";
        q78.Resposta3 = "Catan";
        q78.Resposta4 = "Detetive";
        q78.Resposta5 = "War";
        q78.Respostacorreta = 3;
        q78.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q78);

        // Pergunta 19
        var q79 = new Questao();
        q79.Pergunta = "Qual meu estilo de comida favorito?";
        q79.Resposta1 = "Italiana";
        q79.Resposta2 = "Chinesa";
        q79.Resposta3 = "Brasileira";
        q79.Resposta4 = "Japonesa";
        q79.Resposta5 = "Mexicana";
        q79.Respostacorreta = 3;
        q79.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q79);

        // Pergunta 20
        var q80 = new Questao();
        q80.Pergunta = "Qual minha fruta favorita?";
        q80.Resposta1 = "Maçã";
        q80.Resposta2 = "Banana";
        q80.Resposta3 = "Morango";
        q80.Resposta4 = "Laranja";
        q80.Resposta5 = "Abacaxi";
        q80.Respostacorreta = 3;
        q80.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q80);

        // Pergunta 21
        var q81 = new Questao();
        q81.Pergunta = "Qual meu dia da semana favorito?";
        q81.Resposta1 = "Segunda";
        q81.Resposta2 = "Sexta";
        q81.Resposta3 = "Sábado";
        q81.Resposta4 = "Domingo";
        q81.Resposta5 = "Quarta";
        q81.Respostacorreta = 3;
        q81.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q81);

        // Pergunta 22
        var q82 = new Questao();
        q82.Pergunta = "Qual meu instrumento musical favorito?";
        q82.Resposta1 = "Guitarra";
        q82.Resposta2 = "Piano";
        q82.Resposta3 = "Bateria";
        q82.Resposta4 = "Violão";
        q82.Resposta5 = "Saxofone";
        q82.Respostacorreta = 4;
        q82.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q82);

        // Pergunta 23
        var q83 = new Questao();
        q83.Pergunta = "Qual meu lugar favorito na cidade?";
        q83.Resposta1 = "Praça";
        q83.Resposta2 = "Shopping";
        q83.Resposta3 = "Parque";
        q83.Resposta4 = "Museu";
        q83.Resposta5 = "Cafeteria";
        q83.Respostacorreta = 3;
        q83.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q83);

        // Pergunta 24
        var q84 = new Questao();
        q84.Pergunta = "Qual minha bebida favorita?";
        q84.Resposta1 = "Refrigerante";
        q84.Resposta2 = "Água";
        q84.Resposta3 = "Suco";
        q84.Resposta4 = "Cerveja";
        q84.Resposta5 = "Vinho";
        q84.Respostacorreta = 3;
        q84.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q84);

        // Pergunta 25
        var q85 = new Questao();
        q85.Pergunta = "Qual meu tipo de filme favorito?";
        q85.Resposta1 = "Ação";
        q85.Resposta2 = "Comédia";
        q85.Resposta3 = "Terror";
        q85.Resposta4 = "Drama";
        q85.Resposta5 = "Documentário";
        q85.Respostacorreta = 2;
        q85.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q85);

        // Pergunta 26
        var q86 = new Questao();
        q86.Pergunta = "Qual minha tecnologia favorita?";
        q86.Resposta1 = "Smartphone";
        q86.Resposta2 = "Computador";
        q86.Resposta3 = "Tablet";
        q86.Resposta4 = "Relógio inteligente";
        q86.Resposta5 = "Console de videogame";
        q86.Respostacorreta = 1;
        q86.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q86);

        // Pergunta 27
        var q87 = new Questao();
        q87.Pergunta = "Qual meu personagem de ficção favorito?";
        q87.Resposta1 = "Harry Potter";
        q87.Resposta2 = "Frodo Bolseiro";
        q87.Resposta3 = "Sherlock Holmes";
        q87.Resposta4 = "Katniss Everdeen";
        q87.Resposta5 = "Walter White";
        q87.Respostacorreta = 1;
        q87.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q87);

        // Pergunta 28
        var q88 = new Questao();
        q88.Pergunta = "Qual meu super-herói favorito?";
        q88.Resposta1 = "Batman";
        q88.Resposta2 = "Superman";
        q88.Resposta3 = "Homem-Aranha";
        q88.Resposta4 = "Thor";
        q88.Resposta5 = "Capitão América";
        q88.Respostacorreta = 3;
        q88.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q88);

        // Pergunta 29
        var q89 = new Questao();
        q89.Pergunta = "Qual meu jogo favorito?";
        q89.Resposta1 = "The Legend of Zelda";
        q89.Resposta2 = "Final Fantasy";
        q89.Resposta3 = "Call of Duty";
        q89.Resposta4 = "Minecraft";
        q89.Resposta5 = "The Witcher";
        q89.Respostacorreta = 4;
        q89.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q89);

        // Pergunta 30
        var q90 = new Questao();
        q90.Pergunta = "Qual meu continente favorito para visitar?";
        q90.Resposta1 = "Ásia";
        q90.Resposta2 = "Europa";
        q90.Resposta3 = "África";
        q90.Resposta4 = "América";
        q90.Resposta5 = "Oceania";
        q90.Respostacorreta = 2;
        q90.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q90);

        // Pergunta 31
        var q91 = new Questao();
        q91.Pergunta = "Qual meu tipo de café favorito?";
        q91.Resposta1 = "Espresso";
        q91.Resposta2 = "Cappuccino";
        q91.Resposta3 = "Latte";
        q91.Resposta4 = "Americano";
        q91.Resposta5 = "Frappuccino";
        q91.Respostacorreta = 2;
        q91.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q91);

        // Pergunta 32
        var q92 = new Questao();
        q92.Pergunta = "Qual meu estilo de dança favorito?";
        q92.Resposta1 = "Salsa";
        q92.Resposta2 = "Funk";
        q92.Resposta3 = "Ballet";
        q92.Resposta4 = "Hip Hop";
        q92.Resposta5 = "Jazz";
        q92.Respostacorreta = 1;
        q92.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q92);

        // Pergunta 33
        var q93 = new Questao();
        q93.Pergunta = "Qual meu jogo de cartas favorito?";
        q93.Resposta1 = "Pôquer";
        q93.Resposta2 = "Buraco";
        q93.Resposta3 = "Truco";
        q93.Resposta4 = "UNO";
        q93.Resposta5 = "Magic: The Gathering";
        q93.Respostacorreta = 4;
        q93.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q93);

        // Pergunta 34
        var q94 = new Questao();
        q94.Pergunta = "Qual minha flor favorita?";
        q94.Resposta1 = "Rosa";
        q94.Resposta2 = "Girassol";
        q94.Resposta3 = "Tulipa";
        q94.Resposta4 = "Orquídea";
        q94.Resposta5 = "Lírio";
        q94.Respostacorreta = 1;
        q94.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q94);

        // Pergunta 35
        var q95 = new Questao();
        q95.Pergunta = "Qual meu destino de sonho?";
        q95.Resposta1 = "Maldivas";
        q95.Resposta2 = "Paris";
        q95.Resposta3 = "Nova York";
        q95.Resposta4 = "Tóquio";
        q95.Resposta5 = "Rio de Janeiro";
        q95.Respostacorreta = 2;
        q95.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q95);

        // Pergunta 36
        var q96 = new Questao();
        q96.Pergunta = "Qual meu tema favorito de festa?";
        q96.Resposta1 = "Festa à fantasia";
        q96.Resposta2 = "Aniversário";
        q96.Resposta3 = "Natal";
        q96.Resposta4 = "Ano Novo";
        q96.Resposta5 = "Halloween";
        q96.Respostacorreta = 1;
        q96.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q96);

        // Pergunta 37
        var q97 = new Questao();
        q97.Pergunta = "Qual meu estilo de roupa favorito?";
        q97.Resposta1 = "Casual";
        q97.Resposta2 = "Esportivo";
        q97.Resposta3 = "Formal";
        q97.Resposta4 = "Vintage";
        q97.Resposta5 = "Praiano";
        q97.Respostacorreta = 1;
        q97.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q97);

        // Pergunta 38
        var q98 = new Questao();
        q98.Pergunta = "Qual meu doce favorito de infância?";
        q98.Resposta1 = "Pipoca doce";
        q98.Resposta2 = "Bala";
        q98.Resposta3 = "Chocolate";
        q98.Resposta4 = "Gelatina";
        q98.Resposta5 = "Sorvete";
        q98.Respostacorreta = 3;
        q98.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q98);

        // Pergunta 39
        var q99 = new Questao();
        q99.Pergunta = "Qual meu lugar favorito para relaxar?";
        q99.Resposta1 = "Praia";
        q99.Resposta2 = "Montanha";
        q99.Resposta3 = "Casa";
        q99.Resposta4 = "Cafeteria";
        q99.Resposta5 = "Parque";
        q99.Respostacorreta = 1;
        q99.ConfiguraEstruturaDesenho(labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
        listaQuestoes.Add(q99);

        // Pergunta 40
        var q100 = new Questao();
        q100.Pergunta = "Qual meu sabor de sorvete favorito?";
        q100.Resposta1 = "Chocolate";
        q100.Resposta2 = "Morango";
        q100.Resposta3 = "Baunilha";
        q100.Resposta4 = "Pistache";
        q100.Resposta5 = "Manga";
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

    public async void VerificaCorreto(int RR){
        if (questaoCorrente.VerificaResposta(RR)){
            await Task.Delay (1000); //1 seg
            ProximaQuestao();
        }
    }

    public int Pontuação {get; private set;}
    int NivelAtual = 0;
    void Inicializar ()
    {
        Pontuação = 0;
        NivelAtual = 0;
        ProximaQuestao ();
    }
      public async void VerificaCorreta (int RR)
      {
        if (questaoCorrente.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuação(NivelAtual);
            NivelAtual++;
            ProximaQuestao ();
        }
          else
          {
            await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
          }
      }
      
         
         
        public void AdicionaPontuação (int RR)
         {
            if (RR==1)
            {
                Pontuação= 1000;
            }
            else if (RR==2)
            {
                Pontuação= 2000;
            }
            else if (RR==3)
            {
                Pontuação= 5000;
            }
            else if (RR==4)
            {
                Pontuação= 10000;
            }
            else if (RR==5)
            {
                Pontuação= 20000;
            }
            else if (RR==6)
            {
                Pontuação= 50000;
            }
            else if (RR==7)
            {
                Pontuação= 100000;
            }
            else if (RR==8)
            {
                Pontuação= 500000;
            }
            else if (RR==9)
            {
                Pontuação= 500000;
            }
            else
            {
                Pontuação= 1000000;
            }

         }

}