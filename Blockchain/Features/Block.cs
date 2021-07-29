using System;
using Blockchain.Utils;

namespace Blockchain.Features {
  public class Block {
    private long block;
    private long timestamp;
    private string data;
    private string prevHash;
    private string hash;
    private int nonce;

    public Block() { }

    public Block(long block, long timestamp, string data, string prevHash, string hash, int nonce){
      this.block = block;
      this.timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
      this.data = data;
      this.prevHash = prevHash;
      this.hash = hash;
      this.nonce = nonce;
    }

    public static Block geneses(){
      long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
      return new Block
        {
          block = 0,
          timestamp = timestamp,
          data = "Geneses block",
          prevHash = "0000000000000000000000000000000000000000000000000000000000000000",
          hash = "5DEEEBA5D8127A736E9809697B28C89CE1F59FC6860DB6F67CAB1C590EEF5231",
          nonce = 5110
        };
    }

    public override string ToString(){
      string block = this.block.ToString();
      string timestamp = this.timestamp.ToString();
      string nonce = this.nonce.ToString();
      string result = $"{block}{timestamp}{this.data}{this.prevHash}{nonce}";

      return result;
    }

    public static string calculateHash(string block){
      return Hashing.ToSha256(block);
    }
  }
}
