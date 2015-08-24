<?xml version="1.0" encoding="UTF-8"?>
<!-- Character Card-style character sheet -->
<!-- Version 1.8.1 (September 22, 2007) -->
<!-- Created by Nebular, nebular@shaw.ca -->
<!-- For use with RPGXplorer 1.8.1 http://www.rpgxplorer.com/" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:include href="config/config.xsl"/>
<xsl:template match="/CharacterXMLDataset/Character">
<HTML>
<HEAD>
<TITLE><xsl:value-of select="CharacterName"/>&#160;
<xsl:for-each select="Classes/Class">
	<xsl:value-of select="ClassName"/>&#160;<xsl:value-of select="ClassLevel"/>
	<xsl:if test="position() != last()">/</xsl:if>
</xsl:for-each>
</TITLE>
<META http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<style>
	.master
	{
		BORDER-RIGHT: #000000 2px solid;
		PADDING-RIGHT: 0px;
		BORDER-TOP: #000000 2px solid;
		PADDING-LEFT: 0px;
		PADDING-BOTTOM: 0px;
		MARGIN: 0px;
		BORDER-LEFT: #000000 2px solid;
		WIDTH: 2.874in;
		PADDING-TOP: 0px;
		BORDER-BOTTOM: #000000 2px solid;
		HEIGHT: 4.625in
	}
	.blackbox
	{
		PADDING-RIGHT: 0px;
		PADDING-LEFT: 0px;
		FONT-WEIGHT: bold;
		FONT-SIZE: 10px;
		PADDING-BOTTOM: 0px;
		MARGIN: 0px;
		WIDTH: 0.187in;
		COLOR: #ffffff;
		LINE-HEIGHT: 9px;
		PADDING-TOP: 0px;
		WRITING-MODE: tb-rl;
		BACKGROUND-COLOR: #000000;
		TEXT-ALIGN: center;
		FONT-VARIANT: small-caps;
	}
	.smallbox
	{
		BORDER-RIGHT: #000000 1px solid;
		PADDING-RIGHT: 0px;
		BORDER-TOP: #000000 1px solid;
		PADDING-LEFT: 0px;
		PADDING-BOTTOM: 0px;
		MARGIN: 0px;
		BORDER-LEFT: #000000 1px solid;
		PADDING-TOP: 0px;
		BORDER-BOTTOM: #000000 1px solid;
		HEIGHT: 0.25in
	}
	.text
	{
		FONT-SIZE: 9px;
		LINE-HEIGHT: 9px;
		FONT-FAMILY: Arial
	}
	.textsm
	{
		FONT-SIZE: 6px;
		FONT-FAMILY: Arial;
		LINE-HEIGHT: 6px;
	}
	.textlg
	{
		FONT-SIZE: 11px;
		LINE-HEIGHT: 11px;
		FONT-FAMILY: Arial
	}
	A {
		color: #000000;
		text-decoration: none;
	}
</style>
</HEAD>
	<body>
		<table>
			<tr>
				<td colspan="2" style="height: 5in"></td>
			</tr>
			<tr>
				<td style="width: 3in"></td>
				<td>
					<table class="master" cellspacing="0" cellpadding="0" border="1">
						<tr>
							<td>
								<table width="100%" cellspacing="2" cellpadding="0" border="0">
									<tr style="height: .25in;">
										<td class="blackbox" rowspan="4" align="center" style="width: .187in">Delay or Ready</td>
										<td colspan="8">
											<table width="100%">
												<tr>
													<td class="smallbox" style="width: 2.5in">
														<table width="100%" cellspacing="0" cellpadding="0">
															<tr>
																<td align="left"><font class="textsm">Name<br/></font><font class="textlg">&#160;<xsl:value-of select="CharacterName"/></font></td>
																<td align="right">
																	<font class="textsm">Alignment / Race<br/></font>
																	<font class="textlg">
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
																	<xsl:value-of select="Race"/>
																	</font>
																</td>
															</tr>
														</table>
													</td>
													<td class="smallbox" style="width: .25in" align="center"><font class="textsm">Init<br/></font><font class="textlg"><xsl:value-of select="Initiative"/></font></td>
												</tr>
											</table>
										</td>
									</tr>
									<tr style="height: .25in">
										<td><font class="text">AC</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textsm">Base<br/></font><font class="textlg"><xsl:value-of select="AC"/></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textsm">Touch<br/></font><font class="textlg"><xsl:value-of select="ACTouch"/></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textsm">Flat<br/></font><font class="textlg"><xsl:value-of select="ACFlatfooted"/></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textsm">Temp<br/></font><font class="textlg">&#160;</font></td>
										<td class="smallbox" colspan="3">
											<center><font class="textsm">Class<br/></font>
											<font class="text">
											<xsl:for-each select="Classes/Class">
												<a target="class"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ClassName"/></a><xsl:text> </xsl:text><xsl:value-of select="ClassLevel"/><xsl:text> </xsl:text>
												<xsl:if test="position() != last()"><xsl:text> / </xsl:text></xsl:if>
											</xsl:for-each>
											</font></center>
										</td>
									</tr>
									<tr style="height: .25in">
										<td><font class="text">STR</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="STR"/></font></td>
										<td><font class="text">INT</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="INT"/></font></td>
										<td><font class="text">FORT</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Fortitude"/></font></td>
										<td><font class="text">SPD</font></td>
										<td class="smallbox" style="width: .65in" align="center"><font class="textlg"><xsl:value-of select="Speed"/></font></td>
									</tr>
									<tr style="height: .25in">
										<td><font class="text">DEX</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="DEX"/></font></td>
										<td><font class="text">WIS</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="WIS"/></font></td>
										<td><font class="text">REF</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Reflex"/></font></td>
										<td><font class="text">VIS</font></td>
										<td class="smallbox" style="width: .65in" align="center">
											<font class="text">
											<xsl:choose>
											<xsl:when test="Features/Feature[FeatureName/text()[contains(., 'Darkvision') or contains(., 'Low-Light Vision')]]">
											<xsl:for-each select="Features/Feature[FeatureName/text()[contains(., 'Darkvision') or contains(., 'Low-Light Vision')]]">
												<a target="feature"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a><xsl:text> </xsl:text>
											</xsl:for-each>
											</xsl:when>
											<xsl:otherwise>&#160;</xsl:otherwise>
											</xsl:choose>
											</font>
										</td>
									</tr>
									<tr style="height: .25in">
										<td></td>
										<td><font class="text">CON</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="CON"/></font></td>
										<td><font class="text">CHA</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="CHA"/></font></td>
										<td><font class="text">WILL</font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Will"/></font></td>
										<td><font class="text"><br/></font></td>
										<td align="center"><font class="text"><br/></font></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr style="height: 1in;">
							<td>
								<table width="100%" height="100%" cellspacing="0" cellpadding="2" border="0">
									<tr style="height: .25in;">
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Bluff']/HelpPage"/></xsl:attribute>Bluff</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Bluff']/Final"/></font></td>
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Move Silently']/HelpPage"/></xsl:attribute>Move Silently</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Move Silently']/Final"/></font></td>
										<!--REPLACE AS NEEDED-->
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill1]/HelpPage"/></xsl:attribute><xsl:value-of select="$ExtraSkill1"/></a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill1]/Final"/></font></td>
									</tr>
									<tr style="height: .25in;">
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Diplomacy']/HelpPage"/></xsl:attribute>Diplomacy</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Diplomacy']/Final"/></font></td>
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Search']/HelpPage"/></xsl:attribute>Search</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Search']/Final"/></font></td>
										<!--REPLACE AS NEEDED-->
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill2]/HelpPage"/></xsl:attribute><xsl:value-of select="$ExtraSkill2"/></a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill2]/Final"/></font></td>
									</tr>
									<tr style="height: .25in;">
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Hide']/HelpPage"/></xsl:attribute>Hide</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Hide']/Final"/></font></td>
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Sense Motive']/HelpPage"/></xsl:attribute>Sense Motive</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Sense Motive']/Final"/></font></td>
										<!--REPLACE AS NEEDED-->
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill3]/HelpPage"/></xsl:attribute><xsl:value-of select="$ExtraSkill3"/></a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill3]/Final"/></font></td>
									</tr>
									<tr style="height: .25in;">
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Listen']/HelpPage"/></xsl:attribute>Listen</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Listen']/Final"/></font></td>
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = 'Spot']/HelpPage"/></xsl:attribute>Spot</a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = 'Spot']/Final"/></font></td>
										<!--REPLACE AS NEEDED-->
										<td><font class="text"><a target="skill"><xsl:attribute name="href"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill4]/HelpPage"/></xsl:attribute><xsl:value-of select="$ExtraSkill4"/></a></font></td>
										<td class="smallbox" align="center" style="width: .25in"><font class="textlg"><xsl:value-of select="Skills/Skill[SkillName = $ExtraSkill4]/Final"/></font></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr style="height: .5in;" valign="top">
							<td>
								<table width="100%" cellspacing="0" cellpadding="0" border="0">
									<tr>
										<td><font class="text">Languages</font></td>
									</tr>
									<tr>
										<td>
											<font class="textlg">
											<xsl:for-each select="Languages/Language">
												<a target="language"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="LanguageName"/></a>
												<xsl:if test="position() != last()">, </xsl:if>
											</xsl:for-each>
											</font>
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr style="height: 1.75in;" valign="top">
							<td>
								<table width="100%" cellspacing="0" cellpadding="0" border="0">
									<tr style="height: .5in;">
										<td valign="top" rowspan="2">
											<font class="text">Special/Notes</font><br/>
											<font class="textlg">
												<xsl:for-each select="Feats/Feat[Tags/text()[contains(., 'Special Action')]]">
													<xsl:value-of select="FeatName"/>
													<xsl:if test="position() != last()">, </xsl:if>
												</xsl:for-each>
												<xsl:for-each select="Features/Feature[Tags/text()[contains(., 'Special Action')]]">
													<xsl:value-of select="FeatureName"/>
													<xsl:if test="position() != last()">, </xsl:if>
												</xsl:for-each>
											</font>
										</td>
										<td></td>
									</tr>
									<tr style="height: 1.25in;">
										<td class="blackbox" align="center" style="filter: flipv fliph;">Unconscious</td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	</body>
</HTML>
</xsl:template>
</xsl:stylesheet>