import os,shutil,errno
from os import walk,listdir
from os.path import join,isfile,exists


class DirFileShow:
	"""
	D_path : input directory of the folder (not contain the subfolder)
	D_name : input directory of the subfolder
	F_name : input all directory of all folder
	"""

	def DirShow(inpath):
		if not os.path.exists(inpath):
			print("Folder path not found.")
		else:
			for D_path,D_name,F_name in walk(inpath):
				
				for dirs in D_name:
					print(os.path.join(D_path,dirs))

	def FileShow(inpath):
		if not os.path.exists(inpath):
			print("Folder path not found.")
		else:
			for D_path,D_name,F_name in walk(inpath):
				for files in F_name:
					print(os.path.join(D_path,files))

class DirFileCopy:
	def copyfile(input,output):
		if not exists(input):
			print("Folder path not found.")
		else:
			for filename in listdir(input):
				path = join(input,filename)
				if isfile(path):
					shutil.copy(path, output)
				else:
					continue
			for D_path,D_name,F_name in walk(input):
				for dir in D_name:
					subdir=output + "\\" + dir
					shutil.copytree(join(D_path,dir),subdir)

class DirFileMove:
	def filemove(inpath,outdir):
		if not exists(inpath):
			print("Folder path not found.")
		else:
			shutil.move(inpath,outdir)
