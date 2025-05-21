class Program
{
    static void Main(string[] args)
    {
        ICanal whatsapp = new WhatsApp("+551199999999");
        ICanal telegram = new Telegram("+551188888888", "pedro_bot");
        ICanal facebook = new Facebook("pedro.fb");
        ICanal instagram = new Instagram("pedro.insta");

        Mensagem msgTexto = new TextoMensagem("Olá, tudo bem?");
        Mensagem msgFoto = new MensagemFoto("Olha essa foto", "foto1.jpg", "jpg");
        Mensagem msgVideo = new MensagemVideo("Assista isso!", "video.mp4", "mp4", 45.2);
        Mensagem msgArquivo = new MensagemArquivo("Segue o arquivo", "documento.pdf", "pdf");

        whatsapp.EnviarMensagem(msgTexto);
        telegram.EnviarMensagem(msgFoto);
        facebook.EnviarMensagem(msgVideo);
        instagram.EnviarMensagem(msgArquivo);
    }
}

