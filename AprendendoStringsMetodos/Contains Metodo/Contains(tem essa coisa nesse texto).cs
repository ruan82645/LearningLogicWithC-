//Metodo Contains é bem auto explicativo
//Contem? Contem isso aqui dentro desse texto? 
//Essa é a pergunta feita, então ele retorna um bool de true ou false(obviamente)
//podemos usar para verificar uma palavra ou caracter dentro de um texto
//e depois usar isso para fazer algo mais complexo ou não

string Exemplo1 = "meu carro ta na oficina";
bool Contain = Exemplo1.Contains("meu carro");
//true, tem "meu carro" na frase

//vamos para o exemplo 2, com ele fazendo alguma coisa

string Exemplo2 = "hoje eu fazer uma festa";
string busca = "festa";

bool Contain2 = Exemplo2.Contains(busca);

Console.WriteLine((Contain2) ? "hoje tem festa" : "não tem festa hoje");

