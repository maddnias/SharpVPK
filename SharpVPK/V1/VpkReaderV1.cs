using System.IO;
using System.Runtime.InteropServices;

namespace SharpVPK.V1
{
    internal class VpkReaderV1 : VpkReaderBase
    {
        public VpkReaderV1(string filename) 
            : base(filename)
        {
        }
        public VpkReaderV1(byte[] file)
            : base(file)
        {
        }

        public override IVpkArchiveHeader ReadArchiveHeader()
        {
            var hdrStructSize = Marshal.SizeOf(typeof(VpkArchiveHeaderV1));
            var hdrBuff = Reader.ReadBytes(hdrStructSize);
            return BytesToStructure<VpkArchiveHeaderV1>(hdrBuff);
        }

        public override uint CalculateEntryOffset(uint offset)
        {
            throw new System.NotImplementedException();
        }
    }
}
