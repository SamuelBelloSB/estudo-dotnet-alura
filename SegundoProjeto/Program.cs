Banda Beyonce = new Banda();
Beyonce.Nome = "Beyoncé";

Album albumDaBeyonce = new Album();
albumDaBeyonce.Nome = "Renaissance";

Musica musica1 = new Musica(Beyonce);
musica1.Nome = "Heated";
musica1.Duracao = 228;
musica1.Disponivel = true;
musica1.ExibirFichaTecnica();

Musica musica2 = new Musica(Beyonce);
musica2.Nome = "Alien Superstar";
musica2.Duracao = 260;
musica2.Disponivel = true;
musica2.ExibirFichaTecnica();

albumDaBeyonce.AdicionarMusica(musica1);
albumDaBeyonce.AdicionarMusica(musica2);


Beyonce.AdicionarAlbum(albumDaBeyonce);
Beyonce.ExibirDiscografia();