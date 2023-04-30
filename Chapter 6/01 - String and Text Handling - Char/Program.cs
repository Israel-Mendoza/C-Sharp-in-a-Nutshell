using static System.Console;

char a = 'a';
char tab = '\t';
char one = '1';

// IsWhiteSpace()
WriteLine(char.IsWhiteSpace(a)); // False
WriteLine(char.IsWhiteSpace(tab)); // True
// ToUpper/Lower()
WriteLine(char.ToUpper(a)); // A
// IsLetter()
WriteLine(char.IsLetter(a)); // True
WriteLine(char.IsLetter(tab)); // False
WriteLine(char.IsLetter(one)); // False
// IsDigit()
WriteLine(char.IsDigit(a)); // False
WriteLine(char.IsDigit(tab)); // False
WriteLine(char.IsDigit(one)); // True
// IsLetterOrDigit()
WriteLine(char.IsLetterOrDigit(a)); // True
WriteLine(char.IsLetterOrDigit(tab)); // False
WriteLine(char.IsLetterOrDigit(one)); // True
// IsSeparator()
WriteLine(char.IsSeparator(a)); // False
WriteLine(char.IsSeparator(tab)); // False
WriteLine(char.IsSeparator(' ')); // True
WriteLine(char.IsSeparator(one)); // False
// IsPunctuation
WriteLine(char.IsPunctuation(';')); // True
WriteLine(char.IsPunctuation('!')); // True
WriteLine(char.IsPunctuation('?')); // True
WriteLine(char.IsPunctuation('.')); // True
WriteLine(char.IsPunctuation(a)); // False
WriteLine(char.IsPunctuation(tab)); // False
WriteLine(char.IsPunctuation(one)); // False
WriteLine();
// Unicode
WriteLine(char.ToUpper('猫')); // 猫
WriteLine(char.ToLower('猫')); // 猫
WriteLine(char.IsLetter('猫')); // True
WriteLine(char.IsDigit('猫')); // False
WriteLine(char.IsLetterOrDigit('猫')); // True
WriteLine(char.IsSeparator('猫')); // False
WriteLine(char.IsPunctuation('猫')); // False
