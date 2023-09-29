// See https://aka.ms/new-console-template for more information

using WhashMachine.model;

List<Whasher> whashers = new List<Whasher>();

for (Int16 i = 0; i < 5; ++i)
{
    whashers.Add(new Whasher());
}

whashers[3].CottonWhash(5.5f);
whashers[2].SportWash(2.4f);
