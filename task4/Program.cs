int[,,] array3D = {
    {
        {66, 25},
        {34, 41}
    },
    {
        {27, 90},
        {26, 55}
    }
};

for (int x = 0; x < 2; x++)
{
    for (int y = 0; y < 2; y++)
    {
        for (int z = 0; z < 2; z++)
        {
            Console.WriteLine($"{array3D[x, y, z]}({x},{y},{z})");
        }
    }
}
