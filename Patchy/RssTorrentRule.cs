﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Patchy
{
    public class RssTorrentRule
    {
        public enum RuleType
        {
            Title,
            Description,
            CreatedBy
        }

        public RssTorrentRule()
        {
        }

        public RssTorrentRule(RuleType type, Regex regex)
        {
            Type = type;
            Regex = regex;
        }

        public RuleType Type { get; set; }
        public Regex Regex { get; set; }
    }
}