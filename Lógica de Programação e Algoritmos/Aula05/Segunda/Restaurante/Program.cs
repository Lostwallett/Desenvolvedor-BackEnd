using static System.Console;

async Task Principal()
{
    WriteLine("Pedido anotado.");
    await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkShake());
    WriteLine("Pedido entregue!");
}

async Task PrepararHamburguer()
{
    WriteLine("Preparando o hambúrguer...");
    await Task.Delay(3000);
    WriteLine("Hambúrguer pronto!");    
}

async Task PrepararBatata()
{
    WriteLine("Preparando a batata frita...");
    await Task.Delay(2500);
    WriteLine("Batata frita pronta!");
}

async Task PrepararMilkShake()
{
    WriteLine("Preparando o milkshake...");
    await Task.Delay(4000);
    WriteLine("Milkshake pronto!");
}


await Principal();





ReadKey();
