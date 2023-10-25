CREATE PROC usp_BranchesGetAllBranches
AS

   BEGIN

      SELECT [Branchid],
	         [BranchName],
             [Email],
			 [Telephone],
			 [AddressLine]
	  FROM   [dbo].[Branches]

   END