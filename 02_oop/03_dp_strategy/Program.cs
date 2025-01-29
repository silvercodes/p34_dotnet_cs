
ICompression zipComp = new ZipCompression();
ICompression rarComp = new RarCompression();
ICompression defComp = new DeflateStrategy();

Compressor compressor = new Compressor(zipComp);
Console.WriteLine(compressor.makeArchive("data0.txt"));
Console.WriteLine(compressor.makeArchive("data1.txt"));
compressor.CompressionStrategy = rarComp;
Console.WriteLine(compressor.makeArchive("data0.txt"));
Console.WriteLine(compressor.makeArchive("data1.txt"));
compressor.CompressionStrategy = defComp;
Console.WriteLine(compressor.makeArchive("data0.txt"));
Console.WriteLine(compressor.makeArchive("data1.txt"));

abstract class ICompression
{
    public abstract string Compress(string path);
    public abstract string Decompress(string path);
}
class ZipCompression : ICompression
{
    public override string Compress(string path)
    {
        return $"zip file: {path}.zip";
    }

    public override string Decompress(string path)
    {
        return $"recovered from zip file: {path}";
    }
}
class RarCompression : ICompression
{
    public override string Compress(string path)
    {
        return $"rar file: {path}.rar";
    }

    public override string Decompress(string path)
    {
        return $"recovered from rar file: {path}";
    }
}
class DeflateStrategy: ICompression
{
    public override string Compress(string path)
    {
        return $"deflate file: {path}.def";
    }

    public override string Decompress(string path)
    {
        return $"recovered from deflate file: {path}";
    }
}

class Compressor
{
    public ICompression CompressionStrategy { get; set; }
    public Compressor(ICompression compressionStrategy)
    {
        CompressionStrategy = compressionStrategy;
    }

    public string makeArchive(string path)
    {
        return CompressionStrategy.Compress(path);
    }

    public string recoveryFromArchive(string path)
    {
        return CompressionStrategy.Decompress(path);
    }
}
