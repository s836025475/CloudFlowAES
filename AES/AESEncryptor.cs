using System;
using System.Buffers.Text;

namespace AES
{
    public class AESEncryptor
    {
        public String decrypt(String data)
        {
            byte[] plainData = decrypt(Base64.decodeBase64(data));
            return new String(plainData, CHARSET);
        }

        /**
         * 解密
         *
         * @param data
         * @return
         */
        public byte[] decrypt(byte[] data)
        {
            Key k = new SecretKeySpec(aesKey.getBytes(CHARSET), ALGORITHM);
            byte[] raw = k.getEncoded();
            SecretKeySpec secretKeySpec = new SecretKeySpec(raw, ALGORITHM);
            try
            {
                Cipher cipher = Cipher.getInstance(ALGORITHM);
                cipher.init(Cipher.DECRYPT_MODE, secretKeySpec);
                return cipher.doFinal(data);
            }
            catch (Exception e)
            {
                throw new RuntimeException(e);
            }
        }
}
