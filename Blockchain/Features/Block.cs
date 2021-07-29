using System;

namespace Blockchain.Features {
  class Block {
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
          hash = "8724f78170aee146b794ca6ad451d23c254717727e18e2b9643b81d5666aa908",
          nonce = 5110
        };
    }

    public static string calculateHash(){
      return "";
    }
  }
}
