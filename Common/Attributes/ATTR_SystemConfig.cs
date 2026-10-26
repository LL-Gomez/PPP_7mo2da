using System.Diagnostics.CodeAnalysis;

namespace Common.Attributes
{
    public class ATTR_SystemConfig
    {
        public int MinimumPasswordCharacters;
        public int SecurityQuestionAmount;
        public bool ForcePasswordCaps;
        public bool ForcePasswordNumbers;
        public bool ForcePasswordSpecials;
        public bool TwoFactorRequired;
        public bool AllowOldPasswords;
        public bool VerifyIfHasCredentials;

        [SetsRequiredMembers]
        public ATTR_SystemConfig(int mpa, int sqa, bool fpc, bool fpn, bool fps, bool r2fa, bool aop, bool vihc)
        {
            this.MinimumPasswordCharacters  = mpa;
            this.SecurityQuestionAmount     = sqa;
            this.ForcePasswordCaps          = fpc;
            this.ForcePasswordNumbers       = fpn;
            this.ForcePasswordSpecials      = fps;
            this.TwoFactorRequired          = r2fa;
            this.AllowOldPasswords          = aop;
            this.VerifyIfHasCredentials     = vihc;
        }
    }
}
