/* 
 * Task: Es una clase que nos permite trabajar con tareas asíncronas. Nos permite un mayor control
 * sobre las tareas que los hilos.
*/

// Definición y uso de un task
var task = new Task(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("La tarea interna del task");
});

var task2 = new Task(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("La tarea interna 2 del task");
});

// Inicialización del task. De lo contrario no se ejectuta
task.Start();
task2.Start();

Console.WriteLine("Hago algo más mientras ustedes trabajan");

// El await obliga a que el programa detenga su ejecución hasta que el task haya terminado
await task;
await task2;

// Uso de métodos asíncronos
int resultRandom = await RandomAsync();
Console.WriteLine(resultRandom);

int resultMult = await MultAsync(20);
Console.WriteLine(resultMult);

Console.WriteLine("He terminado la tarea");
Console.ReadLine();

// Definición de métodos asíncronos
static async Task<int> RandomAsync()
{
    var task = new Task<int>(() => new Random().Next(1000));
    task.Start();
    int result = await task;
    return result;    
}

static async Task<int> MultAsync(int num)
{
    var task = new Task<int>(() => num * num);
    task.Start();
    int result = await task;
    return result;

}