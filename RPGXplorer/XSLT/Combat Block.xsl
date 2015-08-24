<?xml version="1.0" encoding="UTF-8"?>
<!-- Combat Block character sheet -->
<!-- Version 1.9.5 (October 5, 2008) -->
<!-- Created by Nebular, nebular@shaw.ca -->
<!-- For use with RPGXplorer 1.9.5 http://www.rpgxplorer.com/" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:include href="config/config.xsl"/>
	<xsl:template match="/CharacterXMLDataset/Character">
		<html>
			<head>
				<META http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
				<title><xsl:value-of select="CharacterName"/>'s Character Sheet</title>
			</head>
			<style>
					div.description
					{
					font-family: Times New Roman, Times Roman, serif;
					font-size: 9pt;
					}
					div.description p
					{
					text-indent: 12pt;
					margin: 6pt 8pt
					}
					div.description table
					{
					text-indent: 0pt;
					margin: 6pt 14pt
					}
					div.description td
					{
					font-family: Times New Roman, Times Roman, serif;
					font-size: 9pt;
					text-indent: 0pt;
					padding: 0pt 6pt
					}
					div.description ul
					{
					position: relative;
					top: 0pt;
					left: -10pt;
					margin-top: 0pt
					}
					.v4 {
					font-family: Verdana;
					font-size:4pt;
					}
					.v5 {
					font-family: Verdana;
					font-size:5pt;
					}
					.v6 {
					font-family: Verdana;
					font-size:6pt;
					}
					.v7 {
					font-family: Verdana;
					font-size:7pt;
					}
					.v8 {
					font-family: Verdana;
					font-size:8pt;
					}
					.v9 {
					font-family: Verdana;
					font-size:9pt;
					}
					.v10 {
					font-family: Verdana;
					font-size:10pt;
					}
					.v14 {
					font-family: Verdana;
					font-size:14pt;
					}
					.v16 {
					font-family: Verdana;
					font-size:16pt;
					}
					.v6w {
					font-family: Verdana;
					font-size:6pt;
					color:white
					}
					.v7w {
					font-family: Verdana;
					font-size:7pt;
					color:white
					}
					.v8w {
					font-family: Verdana;
					font-size:8pt;
					color:white
					}
					.v9w {
					font-family: Verdana;
					font-size:9pt;
					color:white
					}
					.v10w {
					font-family: Verdana;
					font-size:10pt;
					color:white
					}
					.v14w {
					font-family: Verdana;
					font-size:14pt;
					color:white
					}
					A {
					color: #000000;
					text-decoration: none;
					}
					.v7w A {
					color: #ffffff;
					text-decoration: none;
					}
				</style>
			<body>
				<xsl:attribute name="bgcolor">white</xsl:attribute>
				<table border="0" cellpadding="0" cellspacing="0" width="100%" bgcolor="white">
					<tr>
						<td width="9%"></td>
						<td width="9%"></td>
						<td width="9%"></td>
						<td width="9%"></td>
						<td width="8%"></td>
						<td width="8%"></td>
						<td width="8%"></td>
						<td width="40%"></td>
					</tr>
					<tr valign="bottom">
						<td colspan="3" valign="middle" style="border: 2pt solid black" class="v10">
							<b>
							<xsl:text>Name: </xsl:text>
							<xsl:value-of select="CharacterName"/>
							<font face="Verdana" style="font-size:7pt">
							<br/>
							<xsl:text>Player: </xsl:text>
							<xsl:value-of select="player"/>	
							</font>
							</b>
						</td>
						<td colspan="2" valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<b>
							<xsl:text>Init Mod: </xsl:text>
							<font face="Verdana" style="font-size:12pt">
							<xsl:value-of select="Initiative"/>
							</font>
							</b>
						</td>
						<td colspan="2" valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<b>
							<xsl:text>HP: </xsl:text>
							<font face="Verdana" style="font-size:12pt">
							<xsl:value-of select="HP"/>
							</font>
							</b>
						</td>
						<td align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v9">
							<b><xsl:text>Skills / Feats / Special abilities</xsl:text></b>
						</td>
					</tr>
					<tr>
						<td colspan="2" valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Class/Level</xsl:text>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Race</xsl:text>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Alignment</xsl:text>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Speed</xsl:text>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Current</xsl:text><br/>
							<xsl:text>HP</xsl:text>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v10">
							<xsl:text>Subdual</xsl:text><br/>
							<xsl:text>Damage</xsl:text>
						</td>
						<td rowspan="4" valign="top" style="border: 2pt solid black" class="v7">
							<table width="100%" cellspacing="0" cellpadding="4">
								<tr>
									<td class="v7">
										<b><xsl:text>Skills: </xsl:text></b>
										<xsl:for-each select="Skills/Skill">
											<xsl:sort select="SkillName"/>
											<xsl:if test="Final != 'X' and Final != '0'">
												<a target="skill"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SkillName"/></a><xsl:text> </xsl:text><xsl:value-of select="Final"/> <xsl:if test="position() != last()">, </xsl:if> 
											</xsl:if>
										</xsl:for-each>
										<br/><br/>
										<b><xsl:text>Feats: </xsl:text></b>
										<xsl:for-each select="Feats/Feat">
											<xsl:sort select="FeatName"/>
											<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
											<xsl:if test="FocusName"><xsl:text> </xsl:text>(<xsl:value-of select="FocusName"/>)</xsl:if>
											<xsl:if test="position() != last()">, </xsl:if>
										</xsl:for-each>
										<br/><br/>
										
										<xsl:if test="Feats/Feat[Tags/text()[contains(., 'Special Action')]] != '' or Features/Feature[Tags/text()[contains(., 'Special Action')]] != ''">
											<b>Special Actions:</b><br/>
												<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Special Action')]]">
													<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
													<xsl:if test="position() != last()">, </xsl:if>
												</xsl:for-each>
												<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Special Action')]]">
													<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
													<xsl:if test="position() != last()">, </xsl:if>
												</xsl:for-each>
											<br/><br/>
										</xsl:if>
										<xsl:if test="Features/Feature != ''">
											<b>Special Qualities:</b><br/>
											<xsl:for-each select="Features/Feature">
												<xsl:sort select="FeatureName"/>
												<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
												<xsl:if test="position() != last()">, </xsl:if>
											</xsl:for-each>
											<br/><br/>
										</xsl:if>
										
										<xsl:if test="SpellLikeAbilities/SpellLikeAbility">
										<b>Spell-Like Abilities: </b>
										<xsl:for-each select="SpellLikeAbilities/SpellLikeAbility">
											<xsl:sort select="Usage"/>
											<xsl:value-of select="Usage"/> - <i><a target="spell"><xsl:attribute name="href"><xsl:value-of select="AbilitySpell/HelpPage"/></xsl:attribute><xsl:value-of select="SpellName"/></a></i>
											(DC <xsl:value-of select="DC"/>; CL <xsl:value-of select="CasterLevel"/>)<xsl:if test="position() != last()">; </xsl:if>
										</xsl:for-each><br/><br/>
										</xsl:if>

										<xsl:if test="PsiLikeAbilities/PsiLikeAbility">
										<b>Psi-Like Abilities: </b>
										<xsl:for-each select="PsiLikeAbilities/PsiLikeAbility">
											<xsl:sort select="Usage"/>
											<xsl:value-of select="Usage"/> - <i><a target="spell"><xsl:attribute name="href"><xsl:value-of select="AbilityPower/HelpPage"/></xsl:attribute><xsl:value-of select="PowerName"/></a></i>
											(DC <xsl:value-of select="DC"/>; ML <xsl:value-of select="ManifesterLevel"/>)<xsl:if test="position() != last()">; </xsl:if>
										</xsl:for-each><br/><br/>
										</xsl:if>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="2" valign="middle" align="center" style="border: 2pt solid black" class="v10">
							<xsl:for-each select="Classes/Class">
								<a target="class"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ClassName"/></a><xsl:text> </xsl:text><xsl:value-of select="ClassLevel"/>
								<xsl:if test="position() != last()">/</xsl:if>
							</xsl:for-each>
						</td>
						<td valign="bottom" align="center" style="border: 2pt solid black" class="v10">
							<xsl:value-of select="Race"/> 
							<xsl:choose>
								<xsl:when test="FullType">
							(<xsl:value-of select="FullType"/>)
								</xsl:when>
								<xsl:otherwise>
							(Humanoid)
								</xsl:otherwise>
							</xsl:choose>
						</td>
						<td valign="bottom" align="center" style="border: 2pt solid black" class="v10">
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
								<xsl:otherwise>
									<xsl:text>&#160;</xsl:text>
								</xsl:otherwise>
							</xsl:choose>
						</td>
						<td valign="bottom" align="center" style="border: 2pt solid black" class="v10">
							<xsl:if test="Speed">
								<xsl:value-of select="Speed"/>
								<xsl:if test="Fly or Climb or Swim or Burrow">,</xsl:if>
							</xsl:if>
							<xsl:if test="Fly">
								fly <xsl:value-of select="Fly"/>
								<xsl:if test="Climb or Swim or Burrow">,</xsl:if>
							</xsl:if>
							<xsl:if test="Climb">
								climb <xsl:value-of select="Climb"/>
								<xsl:if test="Swim or Burrow">,</xsl:if>
							</xsl:if>
							<xsl:if test="Swim">
								swim <xsl:value-of select="Swim"/>
								<xsl:if test="Burrow">,</xsl:if>
							</xsl:if>
							<xsl:if test="Burrow">
								burrow <xsl:value-of select="Burrow"/>
							</xsl:if>
						</td>
						<td valign="bottom" align="center" style="border: 2pt solid black" class="v10">
							<xsl:value-of select="CurrentHP"/>
						</td>
						<td valign="middle" align="center" style="border: 2pt solid black" class="v10">
							<br/>
						</td>
					</tr>
					<tr>
						<td colspan="3" valign="middle" style="border: 2pt solid black">
							<table width="100%">
								<tr>
									<td align="center" width="28%" class="v4">
									ABILITY<br/>NAME
									</td>
									<td align="center" width="18%" class="v4">
									ABILITY<br/>SCORE
									</td>
									<td align="center" width="18%" class="v4">
									ABILITY<br/>MODIFIER
									</td>
									<td align="center" width="18%" class="v4">
									TEMPORARY<br/>SCORE
									</td>
									<td align="center" width="18%" class="v4">
									TEMPORARY<br/>MODIFIER
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>STR</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="STR"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="STRMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>DEX</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="DEX"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="DEXMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>CON</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="CON"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="CONMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>INT</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="INT"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="INTMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>WIS</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="WIS"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="WISMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
								<tr>
									<td align="center" bgcolor="black" class="v10w">
										<b>CHA</b><br/>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="CHA"/>
										</b>
									</td>
									<td align="center" style="border: 1px solid black" class="v10">
										<b>
											<xsl:value-of select="CHAMod"/>
										</b>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
									<td align="center" style="border: 3px solid lightgray">
									<br/>
									</td>
								</tr>
							</table>
						</td>
						<td valign="top">
							<table width="100%" style="border: 2pt solid black">
								<tr>
									<td align="center"  style="border: 1px solid black" class="v10" bgcolor="#dddddd">
										<xsl:text>Armor</xsl:text><br/>
										<xsl:text>Class</xsl:text>
									</td>
								</tr>
								<tr>
									<td align="center" style="border: 1px solid black" class="v9" bgcolor="#dddddd">
										<b><xsl:value-of select="AC"/></b>
									</td>
								</tr>
								<tr>
									<td align="center"  style="border: 1px solid black" class="v8">
										<xsl:text>Flat-footed</xsl:text>
									</td>
								</tr>
								<tr>
									<td align="center" style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="ACFlatfooted"/></b>
									</td>
								</tr>
								<tr>
									<td align="center"  style="border: 1px solid black" class="v8">
										<xsl:text>Touch</xsl:text>
									</td>
								</tr>
								<tr>
									<td align="center" style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="ACTouch"/></b>
									</td>
								</tr>
								<tr>
									<td align="center"  style="border: 1px solid black" class="v8">
										<xsl:text>Helpless</xsl:text>
									</td>
								</tr>
								<tr>
									<td align="center" style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="ACHelpless"/></b>
									</td>
								</tr>
							</table>
						</td>
						<td colspan="3" valign="top" style="border: 2pt solid black">
							<table width="100%" cellspacing="0">
								<tr>
									<td width="33%"></td>
									<td width="33%"></td>
									<td width="33%"></td>
								</tr>
								<tr>
									<td colspan="3" align="center" style="border: 1px solid black" class="v9" bgcolor="#dddddd">
										<b>
										<xsl:text>Saving Throws</xsl:text>
										</b>
									</td>
								</tr>
								<tr>
									<td align="center"  style="border: 1px solid black" class="v9" bgcolor="#dddddd">
											<b>
										<xsl:text>Fort</xsl:text>
											</b>
									</td>
									<td align="center"  style="border: 1px solid black" class="v9" bgcolor="#dddddd">
											<b>
										<xsl:text>Ref</xsl:text>
											</b>
									</td>
									<td align="center"  style="border: 1px solid black" class="v9" bgcolor="#dddddd">
											<b>
										<xsl:text>Will</xsl:text>
											</b>
									</td>
								</tr>
								<tr>
									<td align="center"  style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="Fortitude"/></b>
									</td>
									<td align="center"  style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="Reflex"/></b>
									</td>
									<td align="center"  style="border: 1px solid black" class="v9">
										<b><xsl:value-of select="Will"/></b>
									</td>
								</tr>
								<tr>
									<td align="center" style="border: 1px solid black" class="v9" bgcolor="#dddddd">
											<b>
										<xsl:text>Melee</xsl:text><br/>
										<xsl:text>Attack Bonus</xsl:text>
											</b>
									</td>
									<td colspan="2" align="center"  style="border: 1px solid black" class="v7">
											<b><xsl:value-of select="Melee"/></b>
									</td>
								</tr>
								<tr>
									<td rowspan="3" align="center" style="border: 1px solid black" class="v9" bgcolor="#dddddd">
											<b>
										<xsl:text>Ranged</xsl:text><br/>
										<xsl:text>Attack Bonus</xsl:text>
											</b>
									</td>
									<td rowspan="3" colspan="2" align="center"  style="border: 1px solid black" class="v7">
										<b><xsl:value-of select="Ranged"/></b>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="7" align="center" style="border: 2pt solid black">
							<xsl:for-each select="Attacks/Attack[Primary/WeaponType = 'Melee' or Secondary/WeaponType = 'Melee']">
								<xsl:for-each select="Primary">
								<table cellpadding="0" cellspacing="0" border="0" width="100%">
									<tr>
										<td rowspan="2" colspan="3" width="30%" align="center" bgcolor="black" class="v7w">
											<b><xsl:value-of select="BaseName"/></b>
											<xsl:if test="AttackNumber">
												x<xsl:value-of select="AttackNumber"/>
											</xsl:if>
										</td>
										<td width="24%" align="center" bgcolor="black" class="v6w">
											<b>TOTAL ATTACK BONUS</b>
										</td>
										<td width="18%" align="center" bgcolor="black" class="v6w">
											<b>DAMAGE</b>
										</td>
										<td width="18%" align="center" bgcolor="black" class="v6w">
											<b>CRITICAL</b>
										</td>
										<td align="center" bgcolor="black" width="10%" class="v6w">
											<b>RANGE</b>
										</td>
									</tr>
									<tr>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Attacks"/></b><br/>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
											<xsl:value-of select="BaseDamage"/>
											<xsl:for-each select="PrimaryExtraDamage/DamageName">
												<xsl:value-of select="."/>
											</xsl:for-each>
											</b><br/>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
												<xsl:choose>
													<xsl:when test="CriticalRange != '20-20'">
														<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:when>
													<xsl:otherwise>
														x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:otherwise>
												</xsl:choose>
											</b>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Range"/></b><br/>
										</td>
									</tr>
								</table>
								</xsl:for-each>
								
								<xsl:for-each select="Secondary">
								<table cellpadding="0" cellspacing="0" border="0" width="100%">
									<tr>
										<td colspan="3" width="30%" align="center" bgcolor="gray" class="v7w">
											<b><xsl:value-of select="BaseName"/></b>
											<xsl:if test="AttackNumber">
												x<xsl:value-of select="AttackNumber"/>
											</xsl:if>
										</td>
										<td width="24%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Attacks"/></b><br/>
										</td>
										<td width="18%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
											<xsl:value-of select="BaseDamage"/>
											<xsl:for-each select="SecondaryExtraDamage/DamageName">
												<xsl:value-of select="."/>
											</xsl:for-each>
											</b><br/>
										</td>
										<td width="18%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
												<xsl:choose>
													<xsl:when test="CriticalRange != '20-20'">
														<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:when>
													<xsl:otherwise>
														x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:otherwise>
												</xsl:choose>
											</b>
										</td>
										<td width="10%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Range"/></b><br/>
										</td>
									</tr>
								</table>
								</xsl:for-each>
							</xsl:for-each>
							
							<xsl:for-each select="Attacks/Attack[Primary/WeaponType = 'Ranged' or Secondary/WeaponType = 'Ranged']">
								<xsl:for-each select="Primary">
								<table cellpadding="0" cellspacing="0" border="0" width="100%">
									<tr>
										<td rowspan="2" colspan="3" width="30%" align="center" bgcolor="black" class="v7w">
											<b><xsl:value-of select="BaseName"/></b>
										</td>
										<td width="24%" align="center" bgcolor="black" class="v6w">
											<b>TOTAL ATTACK BONUS</b>
										</td>
										<td width="18%" align="center" bgcolor="black" class="v6w">
											<b>DAMAGE</b>
										</td>
										<td width="18%" align="center" bgcolor="black" class="v6w">
											<b>CRITICAL</b>
										</td>
										<td align="center" bgcolor="black" width="10%" class="v6w">
											<b>RANGE</b>
										</td>
									</tr>
									<tr>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Attacks"/></b><br/>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
											<xsl:value-of select="BaseDamage"/>
											<xsl:for-each select="PrimaryExtraDamage/DamageName">
												<xsl:value-of select="."/>
											</xsl:for-each>
											</b><br/>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
												<xsl:choose>
													<xsl:when test="CriticalRange != '20-20'">
														<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:when>
													<xsl:otherwise>
														x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:otherwise>
												</xsl:choose>
											</b>
										</td>
										<td valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Range"/></b><br/>
										</td>
									</tr>
								</table>
								</xsl:for-each>
								
								<xsl:for-each select="Secondary">
								<table cellpadding="0" cellspacing="0" border="0" width="100%">
									<tr>
										<td colspan="3" width="30%" align="center" bgcolor="gray" class="v7w">
											<b><xsl:value-of select="BaseName"/></b>
											<xsl:if test="AttackNumber">
												x<xsl:value-of select="AttackNumber"/>
											</xsl:if>
										</td>
										<td width="24%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Attacks"/></b><br/>
										</td>
										<td width="18%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
											<xsl:value-of select="BaseDamage"/>
											<xsl:for-each select="SecondaryExtraDamage/DamageName">
												<xsl:value-of select="."/>
											</xsl:for-each>
											</b><br/>
										</td>
										<td width="18%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b>
												<xsl:choose>
													<xsl:when test="CriticalRange != '20-20'">
														<xsl:value-of select="CriticalRange"/>/x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:when>
													<xsl:otherwise>
														x<xsl:value-of select="CriticalMultiplier"/>
													</xsl:otherwise>
												</xsl:choose>
											</b>
										</td>
										<td width="10%" valign="top" align="center" bgcolor="white" style="border: 1px solid black" class="v6">
											<b><xsl:value-of select="Range"/></b><br/>
										</td>
									</tr>
								</table>
								</xsl:for-each>
							</xsl:for-each>
						</td>
					</tr>
					<tr>
						<td colspan="8" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v9">
							<b><xsl:text>Spells / Powers</xsl:text></b>
						</td>
					</tr>
					<tr>
						<td colspan="8" style="border: 2pt solid black" class="v7">
							<table width="100%" cellspacing="0" cellpadding="4">
								<tr>
									<td class="v7">
										<!--<xsl:apply-templates select="spells-known"/>-->
										<!--<br/><br/>-->
										<!--<xsl:apply-templates select="spells-prepared"/>-->
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
														<xsl:when test="ManifesterLevel = '0'">)</xsl:when>
														<xsl:when test="ManifesterLevel = '1'">st)</xsl:when>
														<xsl:when test="ManifesterLevel = '2'">nd)</xsl:when>
														<xsl:when test="ManifesterLevel = '3'">rd)</xsl:when>
														<xsl:otherwise>th):</xsl:otherwise>
													</xsl:choose>
												</xsl:if>
											</xsl:for-each>, Power Points: <xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/PowerPoints"/>:
											<xsl:for-each select="/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class]">
											<xsl:sort select="ClassName"/>
											<xsl:sort select="PowerLevel"/>
											<br/>
											<xsl:variable name="level" select="PowerLevel"/>
											<xsl:value-of select="PowerLevel"/>
											<xsl:choose>
												<xsl:when test="PowerLevel = '0'"/>
												<xsl:when test="PowerLevel = '1'">st</xsl:when>
												<xsl:when test="PowerLevel = '2'">nd</xsl:when>
												<xsl:when test="PowerLevel = '3'">rd</xsl:when>
												<xsl:otherwise>th</xsl:otherwise>
											</xsl:choose>
											- 
											<xsl:for-each select="Power">
												<xsl:sort select="PowerName"/>
												<a target="power"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="PowerName"/></i></a>
												<xsl:if test="position() != last()">; </xsl:if>
											</xsl:for-each>
											</xsl:for-each>
										</xsl:for-each>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="8" align="center" style="border: 2pt solid black" bgcolor="#dddddd" class="v9">
							<b><xsl:text>Possessions</xsl:text></b>
						</td>
					</tr>
					<tr>
						<td colspan="8" style="border: 2pt solid black" class="v7">
							<table width="100%" cellspacing="0" cellpadding="4">
								<tr>
									<td class="v7">
										<xsl:for-each select="Inventory/InventoryItem">
											<xsl:sort select="ItemName"/>
											<xsl:choose>
												<xsl:when test="ItemName/text()[contains(., '+')] or ItemName/text()[contains(., 'of')] or Enhancement != ''">
													<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><i><xsl:value-of select="ItemName"/></i></a>
													<xsl:if test="Quantity">
														x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
													</xsl:if>
												</xsl:when>
												<xsl:otherwise>
													<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
													<xsl:if test="Quantity">
														x<xsl:value-of select="Quantity"/><xsl:text> </xsl:text>
													</xsl:if>
												</xsl:otherwise>
											</xsl:choose>
											<xsl:if test="position() != last()">; </xsl:if>
										</xsl:for-each>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>