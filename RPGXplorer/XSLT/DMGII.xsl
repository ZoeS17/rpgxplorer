<?xml version="1.0" encoding="UTF-8"?>
<!-- DMG II-style character sheet -->
<!-- Version 1.9.5 (October 20, 2008) -->
<!-- Created by Nebular, nebular@shaw.ca -->
<!-- For use with RPGXplorer 1.9.5 http://www.rpgxplorer.com/" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:include href="config/config.xsl"/>
<xsl:template match="/CharacterXMLDataset/Character">
<HTML>
<HEAD>
<TITLE><xsl:value-of select="CharacterName"/><xsl:text> </xsl:text>
<xsl:for-each select="Classes/Class">
	<xsl:value-of select="ClassName"/><xsl:text> </xsl:text><xsl:value-of select="ClassLevel"/>
	<xsl:if test="position() != last()">/</xsl:if>
</xsl:for-each>
</TITLE>
<META http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<style>
	BODY {
		FONT-FAMILY: arial;
		FONT-SIZE: 10pt;
		COLOR: #000000;
		LINE-HEIGHT: 14pt;
	}
	A {
		FONT-FAMILY: arial;
		FONT-SIZE: 10pt;
		COLOR: #000000;
		TEXT-DECORATION: none;
		LINE-HEIGHT: 14pt;
	}
</style>
</HEAD>
<BODY>

<table width="100%" cellspacing="0" cellpadding="0">
	<tr>
		<td>
			<b><xsl:value-of select="CharacterName"/></b>
		</td>
		<td align="right">
			<b>CR <xsl:value-of select="Level"/></b>
		</td>
	</tr>
</table>
<xsl:value-of select="Gender"/><xsl:text> </xsl:text><xsl:value-of select="Race"/><xsl:text> </xsl:text>
<xsl:for-each select="Classes/Class">
	<a target="class"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ClassName"/></a><xsl:text> </xsl:text><xsl:value-of select="ClassLevel"/>
	<xsl:if test="position() != last()">/</xsl:if>
</xsl:for-each><br/>
<xsl:choose>
	<xsl:when test="Alignment = 'Lawful Good'">
		LG
	</xsl:when>
	<xsl:when test="Alignment = 'Lawful Neutral'">
		LN
	</xsl:when>
	<xsl:when test="Alignment = 'Lawful Evil'">
		LE
	</xsl:when>
	<xsl:when test="Alignment = 'Neutral Good'">
		NG
	</xsl:when>
	<xsl:when test="Alignment = 'True Neutral'">
		N
	</xsl:when>
	<xsl:when test="Alignment = 'Neutral Evil'">
		NE
	</xsl:when>
	<xsl:when test="Alignment = 'Chaotic Good'">
		CG
	</xsl:when>
	<xsl:when test="Alignment = 'Chaotic Neutral'">
		CN
	</xsl:when>
	<xsl:when test="Alignment = 'Chaotic Evil'">
		CE
	</xsl:when>
</xsl:choose>
<xsl:value-of select="Size"/>
<xsl:text> </xsl:text>
<xsl:choose>
	<xsl:when test="FullType">
		<xsl:value-of select="FullType"/><br/>
	</xsl:when>
	<xsl:otherwise>
		Humanoid<br/>
	</xsl:otherwise>
</xsl:choose>

<b>Init </b> <xsl:value-of select="Initiative"/>; <b>Senses </b>
<xsl:for-each select="Skills/Skill">
	<xsl:if test="SkillName = 'Listen'">
		<a target="skill"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SkillName"/></a><xsl:text> </xsl:text>
		<xsl:value-of select="Final"/>, 
	</xsl:if>
	<xsl:if test="SkillName = 'Spot'">
		<a target="skill"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SkillName"/></a><xsl:text> </xsl:text>
		<xsl:value-of select="Final"/>
	</xsl:if>
</xsl:for-each>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Senses')]] != '' or Features/Feature[Tags/text()[contains(., 'Senses')]] != ''">;
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Senses')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Senses')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Senses')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
</xsl:if>
<br/>

<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Aura')]] != '' or Features/Feature[Tags/text()[contains(., 'Aura')]] != ''">
	<b>Aura </b>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Aura')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Aura')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Aura')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<b>Languages </b> 
<xsl:for-each select="Languages/Language">
	<a target="language"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="LanguageName"/></a>
	<xsl:if test="position() != last()">, </xsl:if>
</xsl:for-each>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Language')]] != '' or Features/Feature[Tags/text()[contains(., 'Language')]] != ''">;
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Language')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Language')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Language')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
</xsl:if>

<hr/>
<b>AC </b> <xsl:value-of select="AC"/>, <b>touch</b><xsl:text> </xsl:text><xsl:value-of select="ACTouch"/>, <b>flat-footed</b><xsl:text> </xsl:text><xsl:value-of select="ACFlatfooted"/>, helpless<xsl:text> </xsl:text><xsl:value-of select="ACHelpless"/>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'AC Modifier')]] != '' or Features/Feature[Tags/text()[contains(., 'AC Modifier')]] != ''">;
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'AC Modifier')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'AC Modifier')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'AC Modifier')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
</xsl:if>
<br/>
<b>hp </b> <xsl:value-of select="HP"/> (<xsl:value-of select="sum(Classes/Class/ClassLevel)"/> HD)
<xsl:if test="DR != ''">; <b>DR </b><xsl:value-of select="DR"/></xsl:if>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Hit Points')]] != '' or Features/Feature[Tags/text()[contains(., 'Hit Points')]] != ''">;
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Hit Points')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Hit Points')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Hit Points')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
</xsl:if>
<br/>
<xsl:if test="SR != '0'"><b>SR </b><xsl:value-of select="SR"/><br/></xsl:if>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Resistance')]] != '' or Features/Feature[Tags/text()[contains(., 'Resistance')]] != ''">
	<b>Resist</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Resistance')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Resistance')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Resistance')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Immunity')]] != '' or Features/Feature[Tags/text()[contains(., 'Immunity')]] != ''">
	<b>Immune</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Immunity')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Immunity')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Immunity')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<b>Fort </b> <xsl:value-of select="Fortitude"/>, <b>Ref </b> <xsl:value-of select="Reflex"/>, <b>Will </b> <xsl:value-of select="Will"/><br/>

<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Weakness')]] != '' or Features/Feature[Tags/text()[contains(., 'Weakness')]] != ''">
	<b>Weakness</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Weakness')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Weakness')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Weakness')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
</xsl:if>
<hr/>
<b>Speed </b>
	<xsl:if test="Speed">
		<xsl:value-of select="Speed"/>
		<xsl:variable name="speed" select="Speed"/>
		(<xsl:value-of select="substring-before($speed, ' ') div 5"/> squares)<xsl:if test="Fly or Climb or Swim or Burrow">,</xsl:if>
	</xsl:if>
	<xsl:if test="Fly">
		fly <xsl:value-of select="Fly"/>
		<xsl:variable name="speed" select="Fly"/>
		(<xsl:value-of select="substring-before($speed, ' ') div 5"/> squares)<xsl:if test="Climb or Swim or Burrow">,</xsl:if>
	</xsl:if>
	<xsl:if test="Climb">
		climb <xsl:value-of select="Climb"/>
		<xsl:variable name="speed" select="Climb"/>
		(<xsl:value-of select="substring-before($speed, ' ') div 5"/> squares)<xsl:if test="Swim or Burrow">,</xsl:if>
	</xsl:if>
	<xsl:if test="Swim">
		swim <xsl:value-of select="Swim"/>
		<xsl:variable name="speed" select="Swim"/>
		(<xsl:value-of select="substring-before($speed, ' ') div 5"/> squares)<xsl:if test="Burrow">,</xsl:if>
	</xsl:if>
	<xsl:if test="Burrow">
		burrow <xsl:value-of select="Burrow"/>
		<xsl:variable name="speed" select="Burrow"/>
		(<xsl:value-of select="substring-before($speed, ' ') div 5"/> squares)
	</xsl:if>
	<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Speed')]] != '' or Features/Feature[Tags/text()[contains(., 'Speed')]] != ''">;
		<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Speed')]]">
			<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
			<xsl:if test="position() != last()">, </xsl:if>
			<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Speed')]]">, </xsl:if>
		</xsl:for-each>
		<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Speed')]]">
			<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
			<xsl:if test="position() != last()">, </xsl:if>
		</xsl:for-each>
	</xsl:if>
<br/>

<xsl:if test="Attacks/Attack[Primary/WeaponType = 'Melee' or Secondary/WeaponType = 'Melee'] != ''">
	<b>Melee </b> 
	<xsl:for-each select="Attacks/Attack[Primary/WeaponType = 'Melee' or Secondary/WeaponType = 'Melee']">
		<xsl:for-each select="Primary">
		<xsl:if test="AttackNumber">
			<xsl:value-of select="AttackNumber"/><xsl:text> </xsl:text>
		</xsl:if>
		
		<xsl:choose>
			<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
				<xsl:choose>
					<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
						<i>+<xsl:value-of select="Enhancement"/><xsl:text> </xsl:text><xsl:value-of select="BaseName"/></i><xsl:text> </xsl:text>
					</xsl:when>
				</xsl:choose>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="BaseName"/><xsl:text> </xsl:text>
			</xsl:otherwise>
		</xsl:choose>
		
		<xsl:value-of select="Attacks"/><xsl:text> </xsl:text>
		<xsl:choose>
			<xsl:when test="CriticalRange != '20-20'">
				(<xsl:value-of select="BaseDamage"/>
				<xsl:for-each select="PrimaryExtraDamage/DamageName">
					<xsl:value-of select="."/>
				</xsl:for-each>
				/<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>)
			</xsl:when>
			<xsl:otherwise>
				(<xsl:value-of select="BaseDamage"/>
				<xsl:for-each select="PrimaryExtraDamage/DamageName">
					<xsl:value-of select="."/>
				</xsl:for-each>
				/x<xsl:value-of select="CriticalMultiplier"/>)
			</xsl:otherwise>
		</xsl:choose>
		</xsl:for-each>
		
		<xsl:for-each select="Secondary[WeaponType = 'Melee']">
			<xsl:if test="../Primary">and </xsl:if>
			<xsl:if test="AttackNumber">
				<xsl:value-of select="AttackNumber"/><xsl:text> </xsl:text>
			</xsl:if>
			
			<xsl:choose>
				<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
					<xsl:choose>
						<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
							<i>+<xsl:value-of select="Enhancement"/><xsl:text> </xsl:text><xsl:value-of select="BaseName"/></i><xsl:text> </xsl:text>
						</xsl:when>
					</xsl:choose>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="BaseName"/><xsl:text> </xsl:text>
				</xsl:otherwise>
			</xsl:choose>
			
			<xsl:value-of select="Attacks"/><xsl:text> </xsl:text>
			<xsl:if test="CriticalRange/text() != ''">
			<xsl:choose>
				<xsl:when test="CriticalRange != '20-20'">
					(<xsl:value-of select="BaseDamage"/>
					<xsl:for-each select="SecondaryExtraDamage/DamageName">
						<xsl:value-of select="."/>
					</xsl:for-each>
					/<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>)
				</xsl:when>
				<xsl:otherwise>
					(<xsl:value-of select="BaseDamage"/>
					<xsl:for-each select="SecondaryExtraDamage/DamageName">
						<xsl:value-of select="."/>
					</xsl:for-each>
					/x<xsl:value-of select="CriticalMultiplier"/>)
				</xsl:otherwise>
			</xsl:choose>
			</xsl:if>
		</xsl:for-each>
		
		<xsl:if test="position() != last()">or<br/></xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="Attacks/Attack[Primary/WeaponType = 'Ranged' or Secondary/WeaponType = 'Ranged'] != ''">
	<b>Ranged </b> 
	<xsl:for-each select="Attacks/Attack[Primary/WeaponType = 'Ranged' or Secondary/WeaponType = 'Ranged']">
		<xsl:for-each select="Primary">
		<xsl:if test="AttackNumber">
			<xsl:value-of select="AttackNumber"/><xsl:text> </xsl:text>
		</xsl:if>
		
		<xsl:choose>
			<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
				<xsl:choose>
					<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
						<i>+<xsl:value-of select="Enhancement"/><xsl:text> </xsl:text><xsl:value-of select="BaseName"/></i><xsl:text> </xsl:text>
					</xsl:when>
				</xsl:choose>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="BaseName"/><xsl:text> </xsl:text>
			</xsl:otherwise>
		</xsl:choose>
		
		<xsl:value-of select="Attacks"/><xsl:text> </xsl:text>
		<xsl:choose>
			<xsl:when test="CriticalRange != '20-20'">
				(<xsl:value-of select="BaseDamage"/>
				<xsl:for-each select="PrimaryExtraDamage/DamageName">
					<xsl:value-of select="."/>
				</xsl:for-each>
				/<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>)
			</xsl:when>
			<xsl:otherwise>
				(<xsl:value-of select="BaseDamage"/>
				<xsl:for-each select="PrimaryExtraDamage/DamageName">
					<xsl:value-of select="."/>
				</xsl:for-each>
				/x<xsl:value-of select="CriticalMultiplier"/>)
			</xsl:otherwise>
		</xsl:choose>
		</xsl:for-each>
		
		<xsl:for-each select="Secondary[WeaponType = 'Ranged']">
			<xsl:if test="../Primary">and </xsl:if>
			<xsl:if test="AttackNumber">
				<xsl:value-of select="AttackNumber"/><xsl:text> </xsl:text>
			</xsl:if>
			
			<xsl:choose>
				<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
					<xsl:choose>
						<xsl:when test="BaseName/text()[contains(., '+')] or Enhancement != ''">
							<i>+<xsl:value-of select="Enhancement"/><xsl:text> </xsl:text><xsl:value-of select="BaseName"/></i><xsl:text> </xsl:text>
						</xsl:when>
					</xsl:choose>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="BaseName"/><xsl:text> </xsl:text>
				</xsl:otherwise>
			</xsl:choose>
			
			<xsl:value-of select="Attacks"/><xsl:text> </xsl:text>
			<xsl:if test="CriticalRange/text() != ''">
			<xsl:choose>
				<xsl:when test="CriticalRange != '20-20'">
					(<xsl:value-of select="BaseDamage"/>
					<xsl:for-each select="SecondaryExtraDamage/DamageName">
						<xsl:value-of select="."/>
					</xsl:for-each>
					/<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>)
				</xsl:when>
				<xsl:otherwise>
					(<xsl:value-of select="BaseDamage"/>
					<xsl:for-each select="SecondaryExtraDamage/DamageName">
						<xsl:value-of select="."/>
					</xsl:for-each>
					/x<xsl:value-of select="CriticalMultiplier"/>)
				</xsl:otherwise>
			</xsl:choose>
			</xsl:if>
		</xsl:for-each>
		
		<xsl:if test="position() != last()">or<br/></xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<b>Space </b>
<xsl:choose>
	<xsl:when test="Space">
		<xsl:value-of select="Space"/> ft.;
	</xsl:when>
	<xsl:otherwise>
			5 ft.;
		</xsl:otherwise>
	</xsl:choose>

	<b>Reach </b>
	<xsl:choose>
	<xsl:when test="Reach">
		<xsl:value-of select="Reach"/>
	</xsl:when>
	<xsl:otherwise>
		5 ft.
	</xsl:otherwise>
</xsl:choose>
<br/>

<b>Base Atk </b><xsl:value-of select="BAB1"/>;
<b>Grp </b> <xsl:value-of select="Grapple"/><br/>
<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Attack Option')]] != '' or Features/Feature[Tags/text()[contains(., 'Attack Option')]] != ''">
	<b>Atk Options</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Attack Option')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Attack Option')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Attack Option')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Special Action')]] != '' or Features/Feature[Tags/text()[contains(., 'Special Action')]] != ''">
	<b>Special Actions</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Special Action')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Special Action')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="SpellLikeAbilities/SpellLikeAbility">
<b>Spell-Like Abilities: </b>
<xsl:for-each select="SpellLikeAbilities/SpellLikeAbility">
	<xsl:sort select="Usage"/>
	<xsl:value-of select="Usage"/> - <i><a target="spell"><xsl:attribute name="href"><xsl:value-of select="AbilitySpell/HelpPage"/></xsl:attribute><xsl:value-of select="SpellName"/></a></i>
	(DC <xsl:value-of select="DC"/>; CL <xsl:value-of select="CasterLevel"/>)<xsl:if test="position() != last()">; </xsl:if>
</xsl:for-each><br/>
</xsl:if>

<xsl:if test="PsiLikeAbilities/PsiLikeAbility">
<b>Psi-Like Abilities: </b>
<xsl:for-each select="PsiLikeAbilities/PsiLikeAbility">
	<xsl:sort select="Usage"/>
	<xsl:value-of select="Usage"/> - <i><a target="spell"><xsl:attribute name="href"><xsl:value-of select="AbilityPower/HelpPage"/></xsl:attribute><xsl:value-of select="PowerName"/></a></i>
	(DC <xsl:value-of select="DC"/>; ML <xsl:value-of select="ManifesterLevel"/>)<xsl:if test="position() != last()">; </xsl:if>
</xsl:for-each><br/>
</xsl:if>

<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Spell Modifier')]] != '' or Features/Feature[Tags/text()[contains(., 'Spell Modifier')]] != ''">
	<b>Spell Modifiers</b><xsl:text> </xsl:text>
	<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Spell Modifier')]]">
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
		<xsl:if test="position() = last() and /CharacterXMLDataset/Character/Features/Feature[Tags/text()[contains(., 'Spell Modifier')]]">, </xsl:if>
	</xsl:for-each>
	<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Spell Modifier')]]">
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="Inventory/InventoryItem[Tags/text()[contains(., 'Combat Gear')]] != ''">
	<b>Combat Gear</b><xsl:text> </xsl:text>
	<xsl:for-each select="Inventory/InventoryItem[Tags/text()[contains(., 'Combat Gear')]]">
		<xsl:sort select="ItemName"/>
		<xsl:choose>
			<xsl:when test="ItemName/text()[contains(., '+')] or ItemName/text()[contains(., 'of')] or Enhancement != ''">
				<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="ItemName"/></i></a>
				<xsl:if test="Quantity &gt; 1">
					x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
				</xsl:if>
			</xsl:when>
			<xsl:otherwise>
				<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
				<xsl:if test="Quantity &gt; 1">
					x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
				</xsl:if>
			</xsl:otherwise>
		</xsl:choose>
		<xsl:if test="position() != last()">; </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:for-each select="Spells/ClassSpells[not(ClassName = preceding-sibling::ClassSpells/ClassName)]">
	<xsl:variable name="class" select="ClassName"/>
	<p/><b><xsl:value-of select="ClassName"/> Spells
	<xsl:choose>
		<xsl:when test="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells and $UseSpellsPrepared = 'Yes'">
			Prepared
		</xsl:when>
		<xsl:otherwise>
			Known
		</xsl:otherwise>
	</xsl:choose>
	</b>
	<xsl:for-each select="../../SpellCasterInfo/CasterClass">
		<xsl:if test="ClassName = $class">
			(CL <xsl:value-of select="CasterLevel"/>
			<xsl:choose>
				<xsl:when test="CasterLevel = '0'">):</xsl:when>
				<xsl:when test="CasterLevel = '1'">st):</xsl:when>
				<xsl:when test="CasterLevel = '2'">nd):</xsl:when>
				<xsl:when test="CasterLevel = '3'">rd):</xsl:when>
				<xsl:otherwise>th):</xsl:otherwise>
			</xsl:choose>
		</xsl:if>
	</xsl:for-each>
	<xsl:if test="$UseSpellPoints = 'Yes'">
		<br/><b>Spell Points </b> <xsl:value-of select="../../SpellCasterInfo/CasterClass[ClassName = $class]/SpellPoints"/>
	</xsl:if>

	<xsl:choose>
		<xsl:when test="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells  and $UseSpellsPrepared = 'Yes'">
			<xsl:for-each select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells">
			<xsl:sort select="ClassName"/>
			<xsl:sort select="SlotLevel"/>
			<br/>
			<xsl:variable name="level" select="SlotLevel"/>
			<b><xsl:value-of select="SlotLevel"/>
			<xsl:choose>
				<xsl:when test="SlotLevel = '0'"/>
				<xsl:when test="SlotLevel = '1'">st</xsl:when>
				<xsl:when test="SlotLevel = '2'">nd</xsl:when>
				<xsl:when test="SlotLevel = '3'">rd</xsl:when>
				<xsl:otherwise>th</xsl:otherwise>
			</xsl:choose>
			<xsl:for-each select="../../SpellCasterInfo/CasterClass">
				<xsl:if test="ClassName = $class">
					<xsl:choose>
						<xsl:when test="$level = '0'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD0"/>/day)</xsl:when>
						<xsl:when test="$level = '1'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD1"/>/day)</xsl:when>
						<xsl:when test="$level = '2'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD2"/>/day)</xsl:when>
						<xsl:when test="$level = '3'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD3"/>/day)</xsl:when>
						<xsl:when test="$level = '4'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD4"/>/day)</xsl:when>
						<xsl:when test="$level = '5'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD5"/>/day)</xsl:when>
						<xsl:when test="$level = '6'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD6"/>/day)</xsl:when>
						<xsl:when test="$level = '7'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD7"/>/day)</xsl:when>
						<xsl:when test="$level = '8'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD8"/>/day)</xsl:when>
						<xsl:when test="$level = '9'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD9"/>/day)</xsl:when>
					</xsl:choose>
				</xsl:if>
			</xsl:for-each></b>
			- 
			<xsl:for-each select="MemorizedSpell">
				<xsl:sort select="SpellName"/>
				<xsl:variable name="spellname" select="SpellName"/>
				<a target="spell">
				<xsl:attribute name="href">
					<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/HelpPage"/>
				</xsl:attribute>
				<i><xsl:value-of select="SpellName"/></i></a>
				<xsl:if test="MetaTags">
					(<xsl:value-of select="MetaTags"/>)
				</xsl:if>
				<xsl:if test="position() != last()">; </xsl:if>
			</xsl:for-each>
			</xsl:for-each>
		</xsl:when>
		<xsl:otherwise>
			<xsl:for-each select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]">
			<xsl:sort select="ClassName"/>
			<xsl:sort select="SpellLevel"/>
			<br/>
			<xsl:variable name="level" select="SpellLevel"/>
			<b><xsl:value-of select="SpellLevel"/>
			<xsl:choose>
				<xsl:when test="SpellLevel = '0'"/>
				<xsl:when test="SpellLevel = '1'">st</xsl:when>
				<xsl:when test="SpellLevel = '2'">nd</xsl:when>
				<xsl:when test="SpellLevel = '3'">rd</xsl:when>
				<xsl:otherwise>th</xsl:otherwise>
			</xsl:choose>
			<xsl:for-each select="../../SpellCasterInfo/CasterClass">
				<xsl:if test="ClassName = $class">
					<xsl:choose>
						<xsl:when test="$level = '0'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD0"/>/day)</xsl:when>
						<xsl:when test="$level = '1'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD1"/>/day)</xsl:when>
						<xsl:when test="$level = '2'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD2"/>/day)</xsl:when>
						<xsl:when test="$level = '3'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD3"/>/day)</xsl:when>
						<xsl:when test="$level = '4'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD4"/>/day)</xsl:when>
						<xsl:when test="$level = '5'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD5"/>/day)</xsl:when>
						<xsl:when test="$level = '6'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD6"/>/day)</xsl:when>
						<xsl:when test="$level = '7'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD7"/>/day)</xsl:when>
						<xsl:when test="$level = '8'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD8"/>/day)</xsl:when>
						<xsl:when test="$level = '9'"> (<xsl:value-of select="SpellsPerDay/ClassSPD/SPD9"/>/day)</xsl:when>
					</xsl:choose>
				</xsl:if>
			</xsl:for-each></b>
			- 
			<xsl:for-each select="Spell">
				<xsl:sort select="SpellName"/>
				<a target="spell"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="SpellName"/></i></a>
				<xsl:if test="position() != last()">; </xsl:if>
			</xsl:for-each>
			</xsl:for-each>
		</xsl:otherwise>
	</xsl:choose>
</xsl:for-each>

<xsl:for-each select="Powers/ClassPowers[not(ClassName = preceding-sibling::ClassPowers/ClassName)]">
	<xsl:variable name="class" select="ClassName"/>
	<p/><b><xsl:value-of select="ClassName"/> Powers Known</b>
	<xsl:for-each select="../../ManifesterInfo/ManifesterClass">
		<xsl:if test="ClassName = $class">
			(ML <xsl:value-of select="ManifesterLevel"/>
			<xsl:choose>
				<xsl:when test="ManifesterLevel = '0'">):</xsl:when>
				<xsl:when test="ManifesterLevel = '1'">st):</xsl:when>
				<xsl:when test="ManifesterLevel = '2'">nd):</xsl:when>
				<xsl:when test="ManifesterLevel = '3'">rd):</xsl:when>
				<xsl:otherwise>th):</xsl:otherwise>
			</xsl:choose>
		</xsl:if>
	</xsl:for-each>
	<br/><b>Power Points </b> <xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/PowerPoints"/>
	<xsl:for-each select="/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class]">
	<xsl:sort select="ClassName"/>
	<xsl:sort select="PowerLevel"/>
	<br/>
	<xsl:variable name="level" select="PowerLevel"/>
	<b><xsl:value-of select="PowerLevel"/>
	<xsl:choose>
		<xsl:when test="PowerLevel = '0'"/>
		<xsl:when test="PowerLevel = '1'">st</xsl:when>
		<xsl:when test="PowerLevel = '2'">nd</xsl:when>
		<xsl:when test="PowerLevel = '3'">rd</xsl:when>
		<xsl:otherwise>th</xsl:otherwise>
	</xsl:choose></b>
	- 
	<xsl:for-each select="Power">
		<xsl:sort select="PowerName"/>
		<a target="power"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="PowerName"/></i></a>
		<xsl:if test="position() != last()">; </xsl:if>
	</xsl:for-each>
	</xsl:for-each>
</xsl:for-each>

<hr/>
<b>Abilities</b> Str <xsl:value-of select="STR"/>, Dex <xsl:value-of select="DEX"/>, Con <xsl:value-of select="CON"/>, Int <xsl:value-of select="INT"/>, Wis <xsl:value-of select="WIS"/>, Cha <xsl:value-of select="CHA"/><br/>

<xsl:if test="Features/Feature != ''">
	<b>SQ </b> 
	<xsl:for-each select="Features/Feature">
		<xsl:sort select="FeatureName"/>
		<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>

<xsl:if test="Feats/Feat">
	<b>Feats </b>
	<xsl:for-each select="Feats/Feat">
		<xsl:sort select="FeatName"/>
		<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
		<xsl:if test="FocusName"><xsl:text> </xsl:text>(<xsl:value-of select="FocusName"/>)</xsl:if>
		<xsl:if test="position() != last()">, </xsl:if>
	</xsl:for-each>
	<br/>
</xsl:if>
<b>Skills </b>
<xsl:for-each select="Skills/Skill">
	<xsl:sort select="SkillName"/>
	<xsl:if test="Final != 'X' and Final != '0'">
		<a target="skill"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SkillName"/></a><xsl:text> </xsl:text><xsl:value-of select="Final"/> <xsl:if test="position() != last()">, </xsl:if> 
	</xsl:if>
</xsl:for-each><br/>

<xsl:if test="Inventory/InventoryItem != ''">
	<b>Possessions </b>
	<xsl:for-each select="Inventory/InventoryItem">
		<xsl:sort select="ItemName"/>
		<xsl:choose>
			<xsl:when test="ItemName/text()[contains(., '+')] or ItemName/text()[contains(., 'of')] or Enhancement != ''">
				<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="ItemName"/></i></a>
				<xsl:if test="Quantity &gt; 1">
					x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
				</xsl:if>
			</xsl:when>
			<xsl:otherwise>
				<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
				<xsl:if test="Quantity &gt; 1">
					x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
				</xsl:if>
			</xsl:otherwise>
		</xsl:choose>
		<xsl:if test="position() != last()">; </xsl:if>
	</xsl:for-each><br/>
</xsl:if>

</BODY>
</HTML>
</xsl:template>
</xsl:stylesheet>