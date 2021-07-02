class Solution:
    def numUniqueEmails(self, emails: 'List[str]') -> 'int':
        e = set()
        for email in emails:
            s = email.split('@')
            s[0] = s[0].split('+')
            e.add(s[0][0].replace('.', '') + '@' + s[1])
        return len(e)
