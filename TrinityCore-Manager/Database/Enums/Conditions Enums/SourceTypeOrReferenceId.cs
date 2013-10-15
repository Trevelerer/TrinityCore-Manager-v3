﻿// TrinityCore-Manager
// Copyright (C) 2013 Mitchell Kutchuk
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Enums
{
    public enum SourceTypeOrReferenceId
    {
        CONDITION_SOURCE_TYPE_NONE = 0,
        CONDITION_SOURCE_TYPE_CREATURE_LOOT_TEMPLATE = 1,
        CONDITION_SOURCE_TYPE_DISENCHANT_LOOT_TEMPLATE = 2,
        CONDITION_SOURCE_TYPE_FISHING_LOOT_TEMPLATE = 3,
        CONDITION_SOURCE_TYPE_GAMEOBJECT_LOOT_TEMPLATE = 4,
        CONDITION_SOURCE_TYPE_ITEM_LOOT_TEMPLATE = 5,
        CONDITION_SOURCE_TYPE_MAIL_LOOT_TEMPLATE = 6,
        CONDITION_SOURCE_TYPE_MILLING_LOOT_TEMPLATE = 7,
        CONDITION_SOURCE_TYPE_PICKPOCKETING_LOOT_TEMPLATE = 8,
        CONDITION_SOURCE_TYPE_PROSPECTING_LOOT_TEMPLATE = 9,
        CONDITION_SOURCE_TYPE_REFERENCE_LOOT_TEMPLATE = 10,
        CONDITION_SOURCE_TYPE_SKINNING_LOOT_TEMPLATE = 11,
        CONDITION_SOURCE_TYPE_SPELL_LOOT_TEMPLATE = 12,
        CONDITION_SOURCE_TYPE_SPELL_IMPLICIT_TARGET = 13,
        CONDITION_SOURCE_TYPE_GOSSIP_MENU = 14,
        CONDITION_SOURCE_TYPE_GOSSIP_MENU_OPTION = 15,
        CONDITION_SOURCE_TYPE_CREATURE_TEMPLATE_VEHICLE = 16,
        CONDITION_SOURCE_TYPE_SPELL = 17,
        CONDITION_SOURCE_TYPE_SPELL_CLICK_EVENT = 18,
        CONDITION_SOURCE_TYPE_QUEST_ACCEPT = 19,
        CONDITION_SOURCE_TYPE_QUEST_SHOW_MARK = 20,
        CONDITION_SOURCE_TYPE_VEHICLE_SPELL = 21,
        CONDITION_SOURCE_TYPE_SMART_EVENT = 22,
        CONDITION_SOURCE_TYPE_NPC_VENDOR = 23,
        CONDITION_SOURCE_TYPE_SPELL_PROC = 24,
        CONDITION_SOURCE_TYPE_MAX = 25
    }
}
