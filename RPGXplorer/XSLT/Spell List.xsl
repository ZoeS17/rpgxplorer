<?xml version="1.0" encoding="UTF-8" ?>
<!-- Spell list sheet -->
<!-- Version 1.8.1 (September 22, 2007) -->
<!-- Created by Nebular, nebular@shaw.ca -->
<!-- For use with RPGXplorer 1.8.1 http://www.rpgxplorer.com/" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:include href="config/config.xsl"/>
	<xsl:variable name="lcletters">abcdefghijklmnopqrstuvwxyz</xsl:variable>
	<xsl:variable name="ucletters">ABCDEFGHIJKLMNOPQRSTUVWXYZ</xsl:variable>
	<xsl:variable name="removeplus">+</xsl:variable>
	<xsl:variable name="replaceplus"> </xsl:variable>
	<xsl:template match="/CharacterXMLDataset/Character">
		<HTML>
			<HEAD>
				<TITLE><xsl:value-of select="CharacterName"/></TITLE>
				<META http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
				<STYLE>
					DIV.description {
						FONT-SIZE: 9pt; FONT-FAMILY: Times New Roman, Times Roman, serif
					}
					DIV.description P {
						MARGIN: 6pt 8pt; TEXT-INDENT: 12pt
					}
					DIV.description TABLE {
						MARGIN: 6pt 14pt; TEXT-INDENT: 0pt
					}
					DIV.description TD {
						PADDING-RIGHT: 6pt; PADDING-LEFT: 6pt; FONT-SIZE: 9pt; PADDING-BOTTOM: 0pt; TEXT-INDENT: 0pt; PADDING-TOP: 0pt; FONT-FAMILY: Times New Roman, Times Roman, serif
					}
					DIV.description UL {
						MARGIN-TOP: 0pt; LEFT: -10pt; POSITION: relative; TOP: 0pt
					}
					.wd8 {
						FONT-SIZE: 8pt; FONT-FAMILY: Webdings
					}
					.symbol8 {
						FONT-SIZE: 8pt; FONT-FAMILY: Wingdings
					}
					.symbol9 {
						FONT-SIZE: 9pt; FONT-FAMILY: Wingdings
					}
					.v1 {
						FONT-SIZE: 1pt; FONT-FAMILY: Verdana
					}
					.v2 {
						FONT-SIZE: 2pt; FONT-FAMILY: Verdana
					}
					.v3 {
						FONT-SIZE: 3pt; FONT-FAMILY: Verdana
					}
					.v4 {
						FONT-SIZE: 4pt; FONT-FAMILY: Verdana
					}
					.v5 {
						FONT-SIZE: 5pt; FONT-FAMILY: Verdana
					}
					.v6 {
						FONT-SIZE: 6pt; FONT-FAMILY: Verdana
					}
					.v7 {
						FONT-SIZE: 7pt; FONT-FAMILY: Verdana
					}
					.v8 {
						FONT-SIZE: 8pt; FONT-FAMILY: Verdana
					}
					.v9 {
						FONT-SIZE: 9pt; FONT-FAMILY: Verdana
					}
					.v10 {
						FONT-SIZE: 10pt; FONT-FAMILY: Verdana
					}
					.v5w {
						FONT-SIZE: 5pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.v6w {
						FONT-SIZE: 6pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.v7w {
						FONT-SIZE: 7pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.v8w {
						FONT-SIZE: 8pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.v9w {
						FONT-SIZE: 9pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.v10w {
						FONT-SIZE: 10pt; COLOR: white; FONT-FAMILY: Verdana
					}
					.versionInfo {
						MARGIN-TOP: 0ex; FONT-SIZE: 5pt; MARGIN-BOTTOM: 0ex; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.itemName {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.itemNameDetail {
						MARGIN-TOP: 0ex; FONT-WEIGHT: normal; FONT-SIZE: 6pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 0ex; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.itemDetail {
						MARGIN-TOP: 0ex; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 0ex; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.itemDesc {
						MARGIN-TOP: 0ex; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 3ex; FONT-STYLE: italic; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.weaponHand {
						FONT-SIZE: 9pt; VERTICAL-ALIGN: top; FONT-FAMILY: Wingdings; TEXT-ALIGN: left
					}
					.weaponTwoHanded {
						FONT-SIZE: 6pt; VERTICAL-ALIGN: bottom; FONT-FAMILY: Verdana
					}
					.cellRangeIncHeading {
						BACKGROUND-COLOR: #666666; xborder-right: 1px solid white
					}
					.cellRangeIncHeadingText {
						FONT-WEIGHT: bold; FONT-SIZE: 6pt; TEXT-TRANSFORM: uppercase; COLOR: #ffffff; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.cellRangeIncTop {
						BORDER-RIGHT: white 1px solid; BACKGROUND-COLOR: #dddddd
					}
					.cellRangeIncBottom {
						BORDER-RIGHT: white 1px solid; BORDER-TOP: white 1px solid; BACKGROUND-COLOR: #dddddd
					}
					.cellRangeIncText {
						FONT-SIZE: 6pt; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.cellRangeIncTextHvy {
						FONT-WEIGHT: bold; FONT-SIZE: 6pt; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.loadText {
						MARGIN-TOP: 0ex; FONT-SIZE: 6pt; MARGIN-BOTTOM: 0ex; TEXT-TRANSFORM: uppercase; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.loadTotalCarried {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 8pt; MARGIN-BOTTOM: 0ex; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.classFeatureHead {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; TEXT-TRANSFORM: uppercase; COLOR: #666666; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.classFeatureText {
						MARGIN-TOP: 0ex; FONT-SIZE: 8pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.tableBlockText {
						MARGIN-TOP: 0ex; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.tableHeadingText {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 9pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; TEXT-TRANSFORM: uppercase; COLOR: #ffffff; FONT-FAMILY: Verdana
					}
					.tableCreditHeadingText {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 9pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; TEXT-TRANSFORM: uppercase; COLOR: #000000; FONT-STYLE: italic; FONT-FAMILY: Verdana
					}
					.tableBodyText {
						MARGIN-TOP: 0ex; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; FONT-FAMILY: Verdana
					}
					.tableColumnText {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 6pt; MARGIN-BOTTOM: 0ex; TEXT-TRANSFORM: uppercase; COLOR: #ffffff; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.tableSubColumnText {
						MARGIN-TOP: 0ex; FONT-WEIGHT: bold; FONT-SIZE: 6pt; MARGIN-BOTTOM: 0ex; TEXT-TRANSFORM: uppercase; COLOR: #000000; FONT-FAMILY: Verdana; TEXT-ALIGN: center
					}
					.featText {
						MARGIN-TOP: 0ex; FONT-SIZE: 7pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 1ex; FONT-FAMILY: Verdana; TEXT-ALIGN: left
					}
					.equipmentValue {
						MARGIN-TOP: 0ex; FONT-SIZE: 8pt; MARGIN-BOTTOM: 0ex; MARGIN-LEFT: 0ex; FONT-FAMILY: "Arial Narrow", Verdana; TEXT-ALIGN: right
					}
					.italic {
						FONT-STYLE: italic
					}
					.bold {
						FONT-WEIGHT: bold
					}
					.upCase {
						TEXT-TRANSFORM: uppercase
					}
					.cellUnderline {
						BORDER-BOTTOM: black 1px solid
					}
					.cellUnderlineShaded {
						BORDER-BOTTOM: black 1px solid; BACKGROUND-COLOR: #dddddd
					}
					.tableHeading {
						BORDER-TOP: black 1px solid; BORDER-BOTTOM: black 1px solid; BACKGROUND-COLOR: #000000
					}
					.tableSubHeading {
						BORDER-TOP: #dddddd 1px solid; BORDER-BOTTOM: #dddddd 1px solid; BACKGROUND-COLOR: #dddddd
					}
					.tableSubHeadingTopRuled {
						BORDER-TOP: #000000 1px solid; BORDER-BOTTOM: #dddddd 1px solid; BACKGROUND-COLOR: #dddddd
					}
					A {
						color: #000000;
						text-decoration: none;
					}
					.v10w A {
						color: #ffffff;
						text-decoration: none;
					}
				</STYLE>
			</HEAD>
			<BODY bgColor="white">
				<xsl:for-each select="Spells/ClassSpells[not(ClassName = preceding-sibling::ClassSpells/ClassName)]">
					<xsl:variable name="class" select="ClassName"/>
					<xsl:choose>
						<xsl:when test="ClassName = 'Wizard' or ClassName = 'Sorcerer' or ClassName = 'Bard'">
							<BR style="PAGE-BREAK-AFTER: always"/>
							<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TBODY>
									<TR>
										<TD vAlign="top" width="49%">
											<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TBODY>
													<TR>
														<TD class="v10w" style="BORDER-LEFT: black 3px solid" align="center" bgColor="black">
															<B><xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> SPELLS</B>
															<xsl:if test="$UseSpellPoints = 'Yes'">
																<b> - Spell Points <xsl:value-of select="../../SpellCasterInfo/CasterClass[ClassName = $class]/SpellPoints"/></b>
															</xsl:if>
														</TD>
													</TR>
												</TBODY>
											</TABLE>
										</TD>
									</TR>
								</TBODY>
							</TABLE>
							<xsl:for-each select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]">
							<xsl:sort select="ClassName"/>
							<xsl:sort select="SpellLevel"/>
							<xsl:variable name="level" select="SpellLevel"/>
							<TABLE cellSpacing="0" cellPadding="0" width="100%" align="top" bgColor="white" border="0">
								<TBODY>
									<TR>
										<TD align="middle" width="100%" bgColor="black" colSpan="3" class="v10w"><FONT style="FONT-SIZE: 9pt" face="Verdana" color="white"><B>
											<xsl:value-of select="SpellLevel"/>
											<xsl:choose>
												<xsl:when test="SpellLevel = '0'"/>
												<xsl:when test="SpellLevel = '1'">ST</xsl:when>
												<xsl:when test="SpellLevel = '2'">ND</xsl:when>
												<xsl:when test="SpellLevel = '3'">RD</xsl:when>
												<xsl:otherwise>TH</xsl:otherwise>
											</xsl:choose>-LEVEL <xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> SPELLS </B></FONT>
										</TD>
									</TR>
									<xsl:if test="ClassName = 'Sorcerer' or ClassName = 'Bard'">
									<xsl:for-each select="../../SpellCasterInfo/CasterClass">
										<xsl:if test="ClassName = $class">
											<TR>
												<TD colspan="3" align="left">
													<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black">
													Spells Per Day
													<xsl:choose>
														<xsl:when test="$level = '0'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD0"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD0"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '1'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD1"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD1"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '2'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD2"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD2"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '3'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD3"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD3"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '4'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD4"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD4"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '5'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD5"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD5"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '6'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD6"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD6"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '7'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD7"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD7"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '8'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD8"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD8"/></xsl:call-template></xsl:when>
														<xsl:when test="$level = '9'"><xsl:value-of select="SpellsPerDay/ClassSPD/SPD9"/><xsl:text> </xsl:text><xsl:call-template name="boxes"><xsl:with-param name="count" select="SpellsPerDay/ClassSPD/SPD9"/></xsl:call-template></xsl:when>
													</xsl:choose>
													</FONT>
												</TD>
											</TR>
										</xsl:if>
									</xsl:for-each>
									</xsl:if>
									<xsl:for-each select="Spell">
										<xsl:sort select="School"/>
										<xsl:sort select="SpellName"/>
										<TR>
											<xsl:if test="position() mod 2 = 0">
												<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
											</xsl:if>
											<TD align="left" valign="top" size="140">
												<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black">
												<xsl:choose>
													<xsl:when test="School = 'Abjuration'">Abjur</xsl:when>
													<xsl:when test="School = 'Conjuration'">Conj</xsl:when>
													<xsl:when test="School = 'Divination'">Div</xsl:when>
													<xsl:when test="School = 'Enchantment'">Ench</xsl:when>
													<xsl:when test="School = 'Evocation'">Evoc</xsl:when>
													<xsl:when test="School = 'Illusion'">Illus</xsl:when>
													<xsl:when test="School = 'Necromancy'">Necro</xsl:when>
													<xsl:when test="School = 'Transmutation'">Trans</xsl:when>
													<xsl:when test="School = 'Universal'">Univ</xsl:when>
												</xsl:choose><BR/>
												</FONT>
											</TD>
											<TD valign="top" width="75%">
												<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black">
												<xsl:if test="$class != 'Sorcerer' and $class != 'Bard'">
													<font face="wingdings">ooooo</font>
												</xsl:if>
												<a target="spell"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><B><xsl:value-of select="SpellName"/></B></a>
												<xsl:choose>
													<xsl:when test="contains(Components, 'M')">
														<sup>M</sup>
														<xsl:if test="contains(Components, 'XP')">
															<sup>,X</sup>
														</xsl:if>
													</xsl:when>
													<xsl:otherwise>
														<xsl:if test="contains(Components, 'XP')">
															<sup>XP</sup>
														</xsl:if>
													</xsl:otherwise>
												</xsl:choose>: <xsl:value-of select="Description"/><BR/></FONT>
											</TD>
											<TD align="left" width="20%" valign="top">
												<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><xsl:value-of select="Sourcebook"/>&#160;<xsl:value-of select="PageNo"/><BR/></FONT>
											</TD>
										</TR>
									</xsl:for-each>
								</TBODY>
							</TABLE>
							</xsl:for-each>
						</xsl:when>
						<xsl:otherwise>
							<BR style="PAGE-BREAK-AFTER: always"/>
							<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TBODY>
									<TR>
										<TD vAlign="top" width="49%">
											<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TBODY>
													<TR>
														<TD class="v10w" style="BORDER-LEFT: black 3px solid" align="center" bgColor="black">
															<B><xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> SPELLS</B>
															<xsl:if test="$UseSpellPoints = 'Yes'">
																<b> - Spell Points <xsl:value-of select="../../SpellCasterInfo/CasterClass[ClassName = $class]/SpellPoints"/></b>
															</xsl:if>
														</TD>
													</TR>
												</TBODY>
											</TABLE>
										</TD>
									</TR>
								</TBODY>
							</TABLE>
							<xsl:for-each select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]">
							<xsl:sort select="ClassName"/>
							<xsl:sort select="SpellLevel"/>
							<xsl:variable name="level" select="SpellLevel"/>
							<TABLE cellSpacing="0" cellPadding="0" width="100%" align="top" bgColor="white" border="0">
								<TBODY>
									<TR>
										<TD align="middle" width="100%" bgColor="black" colSpan="3" class="v10w"><FONT style="FONT-SIZE: 9pt" face="Verdana" color="white"><B>
											<xsl:value-of select="SpellLevel"/>
											<xsl:choose>
												<xsl:when test="SpellLevel = '0'"/>
												<xsl:when test="SpellLevel = '1'">ST</xsl:when>
												<xsl:when test="SpellLevel = '2'">ND</xsl:when>
												<xsl:when test="SpellLevel = '3'">RD</xsl:when>
												<xsl:otherwise>TH</xsl:otherwise>
											</xsl:choose>-LEVEL <xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> SPELLS</B></FONT>
										</TD>
									</TR>
									<xsl:for-each select="Spell">
										<xsl:sort select="SpellName"/>
										<TR>
											<xsl:if test="position() mod 2 = 0">
												<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
											</xsl:if>
											<TD align="middle"><FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><BR/>
												</FONT>
											</TD>
											<TD width="79%" valign="top">
												<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><a target="spell"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><B><xsl:value-of select="SpellName"/></B></a>
												<xsl:choose>
													<xsl:when test="contains(Components, 'M')">
														<sup>M</sup>
														<xsl:if test="contains(Components, 'XP')">
															<sup>,X</sup>
														</xsl:if>
													</xsl:when>
													<xsl:otherwise>
														<xsl:if test="contains(Components, 'XP')">
															<sup>XP</sup>
														</xsl:if>
													</xsl:otherwise>
												</xsl:choose>: <xsl:value-of select="Description"/><BR/></FONT>
											</TD>
											<TD align="left" width="20%" valign="top">
												<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><xsl:value-of select="Sourcebook"/>&#160;<xsl:value-of select="PageNo"/><BR/></FONT>
											</TD>
										</TR>
									</xsl:for-each>
								</TBODY>
							</TABLE>
							</xsl:for-each>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:for-each>
				
				<xsl:for-each select="Powers/ClassPowers[not(ClassName = preceding-sibling::ClassPowers/ClassName)]">
					<xsl:variable name="class" select="ClassName"/>
					<BR style="PAGE-BREAK-AFTER: always"/>
					<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
						<TBODY>
							<TR>
								<TD vAlign="top" width="49%">
									<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TBODY>
											<TR>
												<TD class="v10w" style="BORDER-LEFT: black 3px solid" align="center" bgColor="black">
													<B><xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> POWERS</B>
													<b> - Power Points <xsl:value-of select="../../ManifesterInfo/PowerPoints"/></b>
												</TD>
											</TR>
										</TBODY>
									</TABLE>
								</TD>
							</TR>
						</TBODY>
					</TABLE>
					<xsl:for-each select="/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class]">
					<xsl:sort select="ClassName"/>
					<xsl:sort select="PowerLevel"/>
					<xsl:variable name="level" select="PowerLevel"/>
					<TABLE cellSpacing="0" cellPadding="0" width="100%" align="top" bgColor="white" border="0">
						<TBODY>
							<TR>
								<TD align="middle" width="100%" bgColor="black" colSpan="3" class="v10w"><FONT style="FONT-SIZE: 9pt" face="Verdana" color="white"><B>
									<xsl:value-of select="PowerLevel"/>
									<xsl:choose>
										<xsl:when test="PowerLevel = '0'"/>
										<xsl:when test="PowerLevel = '1'">ST</xsl:when>
										<xsl:when test="PowerLevel = '2'">ND</xsl:when>
										<xsl:when test="PowerLevel = '3'">RD</xsl:when>
										<xsl:otherwise>TH</xsl:otherwise>
									</xsl:choose>-LEVEL <xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> POWERS</B></FONT>
								</TD>
							</TR>
							
							<xsl:for-each select="Power">
								<xsl:sort select="PowerName"/>
								<TR>
									<xsl:if test="position() mod 2 = 0">
										<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
									</xsl:if>
									<TD align="middle"><FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><BR/>
										</FONT>
									</TD>
									<TD width="79%" valign="top">
										<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><a target="power"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><B><xsl:value-of select="PowerName"/></B></a>
										<xsl:choose>
											<xsl:when test="contains(Components, 'M')">
												<sup>M</sup>
												<xsl:if test="contains(Components, 'XP')">
													<sup>,X</sup>
												</xsl:if>
											</xsl:when>
											<xsl:otherwise>
												<xsl:if test="contains(Components, 'XP')">
													<sup>XP</sup>
												</xsl:if>
											</xsl:otherwise>
										</xsl:choose>: <xsl:value-of select="Description"/><BR/></FONT>
									</TD>
									<TD align="left" width="20%" valign="top">
										<FONT style="FONT-SIZE: 10pt" face="Verdana" color="black"><xsl:value-of select="Sourcebook"/>&#160;<xsl:value-of select="PageNo"/><BR/></FONT>
									</TD>
								</TR>
							</xsl:for-each>
						</TBODY>
					</TABLE>
					</xsl:for-each>
				</xsl:for-each>
			</BODY>
		</HTML>
	</xsl:template>
	
	<xsl:template name="boxes">
		<xsl:param name="count" select="1"/>
		<xsl:if test="$count > 0">
			<font face="wingdings">o</font>
			<xsl:call-template name="boxes">
				<xsl:with-param name="count" select="$count - 1"/>
			</xsl:call-template>
		</xsl:if>
	</xsl:template>
</xsl:stylesheet>