﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABPUtils
{
    internal class ConstString
    {
        public const string PATCH_FILE = "patch.xml";
        public const string EASYLIST = "easylist.txt";
        public const string CHINALIST_LAZY_HEADER = @"[Adblock Plus 1.2]
!  Adblock Plus List with Main Focus on Chinese Sites.
!  Last Modified:  
!  Homepage: http://adblock-chinalist.googlecode.com/
!
!  ChinaList Lazy = Part of EasyList + ChinaList + Part of EasyPrivacy
!  If you need to know the details,
!  please visit: https://code.google.com/p/adblock-chinalist/wiki/something_about_ChinaList_Lazy
!
!  If you need help or have any question,
!  please visit: http://adblock-chinalist.googlecode.com/
!
!  coding: utf-8, expires: 5 days
!--CC-BY-SA 3.0 + Licensed, NO WARRANTY but Best Wishes----
";
        public const string HELP_INFO = @"Copyright (C) 2008 - 2012 Adblock Plus ChinaList Project
This is free software. You may redistribute copies of it under the terms of
the GNU LGPL License <http://www.gnu.org/copyleft/lesser.html>.
Usage: ABPUtils.exe -n -d=google.com -dns=8.8.8.8
       ABPUtils.exe -v -i=adblock.txt
       ABPUtils.exe -u -i=adblock.txt
       ABPUtils.exe -m -i=adblock.txt -patch -o=adblock-lazy.txt

  version        Show ABPUtils version.

  c, check       Check the domains in the specific input file.

  d, domain      The domain need to be checked (required).

  m, merge       Merge the specific input file with Part of EasyList and
                 EasyPrivacy.

  n, nsookup     Show the ns server of the specific domain.

  u, update      Update and validate the checksum of the specific input file.

  v, validate    Validate the checksum of the specific input file.

  i, input       Input file with filters to process (required).

  o, output      Output file with processed filters.

  patch          Use the patch.xml.

  p, proxy       Proxy server used when download the lastest EasyList and EasyPrivacy files (optional).

  dns            DNS server (optional).

  h, help        Dispaly this help screen.";

        public const string EASYLIST_URL = "https://easylist-downloads.adblockplus.org/easylist.txt";
        public const string EASYPRIVACY = "easyprivacy.txt";
        public const string EASYPRIVACY_URL = "https://easylist-downloads.adblockplus.org/easyprivacy.txt";
        public const string CHINALIST_LAZY_HEADER_MARK = "!----------------------------White List--------------------";
        public const string CHINALIST_END_MARK = "!------------------------End of List-------------------------";
        public const int EASYLIST_EASYLIST_GENERAL_BLOCK = 1;
        public const int EASYLIST_EASYLIST_GENERAL_HIDE = 2;
        public const int EASYLIST_EASYLIST_ADSERVERS = 3;
        public const int EASYLIST_ADULT_ADULT_ADSERVERS = 4;
        public const int EASYLIST_EASYLIST_THIRDPARTY = 5;
        public const int EASYLIST_ADULT_ADULT_THIRDPARTY = 6;
        public const int EASYLIST_EASYLIST_SPECIFIC_BLOCK = 7;//ignore
        public const int EASYLIST_ADULT_ADULT_SPECIFIC_BLOCK = 8;//ignore
        public const int EASYLIST_EASYLIST_SPECIFIC_HIDE = 9;//ignore
        public const int EASYLIST_ADULT_ADULT_SPECIFIC_HIDE = 10;//ignore
        public const int EASYLIST_EASYLIST_WHITELIST = 11;//ignore
        public const int EASYLIST_ADULT_ADULT_WHITELIST = 12;//ignore

        public const int EASYPRIVACY_GENERAL = 1;
        public const int EASYPRIVACY_TRACKINGSERVERS = 2;
        public const int EASYPRIVACY_TRACKINGSERVERS_INTERNATIONAL = 3;
        public const int EASYPRIVACY_THIRDPARTY = 4;
        public const int EASYPRIVACY_THIRDPARTY_INTERNATIONAL = 5;
        public const int EASYPRIVACY_SPECIFIC = 6;
        public const int EASYPRIVACY_SPECIFIC_INTERNATIONAL = 7;//ignore
        public const int EASYPRIVACY_WHITELIST = 8;
        public const int EASYPRIVACY_WHITELIST_INTERNATIONAL = 9;//ignore

    }
}
