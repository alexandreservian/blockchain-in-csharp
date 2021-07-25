using System;
using System.Text;
using System.Security.Cryptography;

namespace Blockchain.Utils{
  public static class Hashing {
    public static string ToSha256(string data) {
      byte[] bytes = Encoding.UTF8.GetBytes(data);
      byte[] hashBytes = SHA256.HashData(bytes);
      string result = BitConverter.ToString(hashBytes).Replace("-","");
      return result;
    }
  }
}
